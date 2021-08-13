﻿using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoomDTO> UpdateHotelRoom(int roomId, HotelRoomDTO hotelRoomDTO);
        //public Task<HotelRoomDTO> GetHotelRoom(int roomId, string checkInDate = null, string checkOutDate = null);
        public Task<HotelRoomDTO> GetHotelRoom(int roomId);
        public Task<int> DeleteHotelRoom(int roomId);
        public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms();
        //public Task<HotelRoomDTO> IsSameNameRoomAlreadyPresent(string name);
        //public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms(string checkInDate = null, string checkOutDate = null);
        //public Task<HotelRoomDTO> IsRoomUnique(string name, int roomId = 0);
        public Task<HotelRoomDTO> IsRoomUnique(string name);
        //public Task<bool> IsRoomBooked(int RoomId, string checkInDate, string checkOutDate);
    }
}
