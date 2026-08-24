using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace HospitalTest
{
    public class Tests
    {
        private List<Patient> GetPatients()
        {
            return new List<Patient>
            {
                new Patient("Babita", 123, "Critical"),
                new Patient("Prashansa", 103, "Urgent"),
                new Patient("Ganesh", 312, "Standard"),
                new Patient("Himanshu", 568, "Urgent"),
                new Patient("Pooja", 293, "Critical")
            };
        }

        private Doctor CreateDoctors()
        {
            Doctor d1 = new Doctor("Anoop", false);
            Doctor d2 = new Doctor("Anisa", false);
            Doctor d3 = new Doctor("Mukesh", false);

            d1.Next = d2;
            d2.Next = d3;
            d3.Next = d1;

            return d1;
        }

        private Bed CreateBeds()
        {
            Bed b1 = new Bed(1, true);
            Bed b2 = new Bed(2, true);
            Bed b3 = new Bed(3, true);

            b1.Next = b2;
            b2.Prev = b1;

            b2.Next = b3;
            b3.Prev = b2;

            return b1;
        }


        // TEST 1 Patient does not exist
        [Test]
        public void PatientSearch_PatientDoesNotExist_ReturnsMinusOne()
        {
            var patients = GetPatients();

            int result =Hospital.PatientSearch(patients, 999);

            Assert.That(result, Is.EqualTo(-1));
        }

        // TEST 2 Empty patient list
        [Test]
        public void PatientSearch_EmptyList_ReturnsMinusOne()
        {
            var patients = new List<Patient>();

            int result = Hospital.PatientSearch(patients, 100);

            Assert.That(result, Is.EqualTo(-1));
        }



        // TEST 3 Patient found
        [Test]
        public void PatientSearch_FirstPatient_ReturnsCorrectIndex()
        {
            var patients = GetPatients();

            int result = Hospital.PatientSearch(patients, 103);

            Assert.That(result, Is.EqualTo(0));
        }


        // TEST 4 Patient search - middle patient
        [Test]
        public void PatientSearch_MiddlePatient_ReturnsCorrectIndex()
        {
            var patients = GetPatients();

            int result = Hospital.PatientSearch(patients, 293);

            Assert.That(result, Is.EqualTo(2));
        }


        // TEST 5 Patient search - last patient

        [Test]
        public void PatientSearch_LastPatient_ReturnsCorrectIndex()
        {
            var patients = GetPatients();

            int result =
                Hospital.PatientSearch(patients, 568);

            Assert.That(result, Is.EqualTo(4));
        }


        // TEST 6 Doctor circular linked list

        [Test]
        public void DoctorList_IsCircular()
        {
            Doctor head = CreateDoctors();

            Assert.That(head, Is.Not.Null);
            Assert.That(head.Next, Is.Not.Null);
            Assert.That(head.Next.Next, Is.Not.Null);

            // Mukesh should point back to Anoop
            Assert.That(
                head.Next.Next.Next,
                Is.SameAs(head));
        }


        // TEST 7 Doctor assignment

        [Test]
        public void AddDoctor_AvailableDoctor_BecomesBusy()
        {
            Doctor head = CreateDoctors();

            Patient patient =
                new Patient(
                    "Babita",
                    123,
                    "Critical");

            Hospital.AddDoctor(
                patient,
                head);

            Assert.That(
                head.IsBusy,
                Is.True);
        }


        // TEST 8 All doctors busy
        [Test]
        public void AddDoctor_AllDoctorsBusy_DoesNotAssignNewDoctor()
        {
            Doctor head = CreateDoctors();

            // Make all doctors busy
            head.IsBusy = true;
            head.Next.IsBusy = true;
            head.Next.Next.IsBusy = true;

            Patient patient =
                new Patient(
                    "Babita",
                    123,
                    "Critical");

            var output = new StringWriter();

            Console.SetOut(output);

            Hospital.AddDoctor(
                patient,
                head);

            string result =
                output.ToString();

            Assert.That(
                result,
                Does.Contain(
                    "All our Doctors are busy!!"));
        }


        // TEST 9 Bed occupancy
        [Test]
        public void BedOccupancy_AvailableBed_BecomesOccupied()
        {
            Bed head = CreateBeds();

            Patient patient = new Patient("Pooja", 293, "Critical");

            Hospital.BedOccupancy(patient, head);

            Assert.That(head.IsAvail,Is.False);
        }


        // TEST 10 No bed available

        [Test]
        public void BedOccupancy_NoBedAvailable_PrintsMessage()
        {
            Bed head = CreateBeds();

            head.IsAvail = false;
            head.Next.IsAvail = false;
            head.Next.Next.IsAvail = false;

            Patient patient =new Patient("Pooja",293,"Critical");

            var output = new StringWriter();

            Console.SetOut(output);

            Hospital.BedOccupancy(patient,head);

            string result = output.ToString();

            Assert.That(result,Does.Contain("Bed not available"));
        }
    }
}