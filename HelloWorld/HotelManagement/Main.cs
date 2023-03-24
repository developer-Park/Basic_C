﻿// See https://aka.ms/new-console-template for more information
using HotelManagement.Entity;
using HotelManagement.Service;


//Add Hotel
HotelService hotelService = new HotelService();
Console.Write("what's your hotel name? ");
String hotelName = Console.ReadLine();

Console.Write("what's your hotel password? ");
String password = Console.ReadLine();
String successAddHotel = hotelService.addHotel(hotelName, password);
Console.WriteLine(successAddHotel);

//Add Room
var romms = hotelService.addRoom();

/*

while (true)
{
    Console.WriteLine("-----------------------");
    Console.WriteLine("");
    Console.WriteLine("1.게스트 추가");
    Console.WriteLine("2.호텔 예약");
    Console.WriteLine("3.호텔의 모든 예약조회");
    Console.WriteLine("4.고객 자신의 예약조회");
    Console.WriteLine("5.고객 자신의 예약취소");
    Console.WriteLine("6.나가기");
    Console.WriteLine("원하시는 번호 입력 : ");

    Sring a = Console.ReadLine();
    if (a == 1)
    {
        System.out.print("고객이름 : ");
        String customerName = sc.next();
        System.out.print("고객 전화번호 :");
        String customerPhoneNumber = sc.next();
        if (OtherService.validPhoneNumber(customerPhoneNumber))
        {
            System.out.print("고객이 가진돈 : ");
            int customerMoney = sc.nextInt();
            customerService.addCustomer(customerName, customerPhoneNumber, customerMoney);
            customerService.reservationList();
        }

    }
    else if (a == 2)
    {
        System.out.print("룸 사이즈 : ");
        String roomSize = sc.next();
        System.out.println("예약날짜");

        System.out.print("고객이름 : ");
        String customerName = sc.next();
        System.out.print("고객 전화번호 :");
        String customerPhoneNumber = sc.next();
        customerService.makingReservation(roomSize, customerName, customerPhoneNumber, hotel, hotelService.addRoom());
    }
    else if (a == 3)
    {
        System.out.println("전체객실 조회");
        hotelService.getAllList();
    }
    else if (a == 4)
    {
        System.out.print("예약번호 : ");
        String reservationNumber = sc.next();
        customerService.checkCustomerOwnReservation(reservationNumber);

    }
    else if (a == 5)
    {
        System.out.print("예약번호 : ");
        String reservationNumber = sc.next();
        customerService.deleteCustomerOwnReservation(reservationNumber, hotel, hotelService.addRoom());

    }
    else if (a == 6)
    {
        break;
    }
    else if (a == 0)
    {
        otherService.getSevenDate();
    }
}

*/
