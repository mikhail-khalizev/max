// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles

using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class Definitions : IDefinitionGroup
    {
        #region My

        public static Address my_main { get; } = 0x1010_883e;
        public static Address my_min { get; } = 0x1008_9784;
        public static Address my_fopen { get; } = 0x100e_f41f;
        public static Address my_fseek { get; } = 0x100e_f455;
        public static Address my_fread { get; } = 0x100e_f48f;

        public static Address my_play_video_company { get; } = 0x1011_57ff;
        // Анимация карты при запуске ?
        public static Address my_game_map_start_animation { get; } = 0x100f_ded4;

        public static Address my_get_res_data_by_id { get; } = 0x1013_3fd8;
        public static Address my_get_res_data_by_id_malloc { get; } = 0x1013_41eb;

        public static Address my_set_al_1 { get; } = 0x1014_24cc;
        public static Address my_set_al_1_v2 { get; } = 0x1010_2b40;

        public static Address my_ctor_c1 { get; } = 0x1007_abdb;
        public static Address my_ctor_c2 { get; } = 0x1008_caea;
        public static Address my_ctor_c3 { get; } = 0x1009_8852;
        public static Address my_ctor_c4 { get; } = 0x1009_9662;
        public static Address my_ctor_c5 { get; } = 0x1009_9918;
        public static Address my_ctor_c6 { get; } = 0x1009_9b88;
        public static Address my_ctor_c7 { get; } = 0x1009_9d3d;
        public static Address my_ctor_c8 { get; } = 0x1009_9ee1;
        public static Address my_ctor_c9 { get; } = 0x1009_d12a;
        public static Address my_ctor_c10 { get; } = 0x100e_9096;
        public static Address my_ctor_c11 { get; } = 0x100a_38c9;
        public static Address my_ctor_c12 { get; } = 0x100a_606c;
        public static Address my_ctor_c13 { get; } = 0x100a_764f;
        public static Address my_ctor_c14 { get; } = 0x100b_8cbf;
        public static Address my_ctor_c15 { get; } = 0x100c_b888;
        public static Address my_ctor_c16 { get; } = 0x100c_ce2a;
        public static Address my_ctor_c17 { get; } = 0x100c_e40f;
        public static Address my_ctor_c18 { get; } = 0x100c_d35d;
        public static Address my_ctor_c19 { get; } = 0x100d_7c5e;
        public static Address my_ctor_c20 { get; } = 0x1011_9f56;
        public static Address my_ctor_c21 { get; } = 0x1014_16cc;

        public static Address my_ctor_0x101b_38f8 { get; } = 0x1007_66f0;
        public static Address my_ctor_0x101b_4184 { get; } = 0x1007_6af0;
        public static Address my_ctor_0x101b_38d0 { get; } = 0x1007_6844;
        public static Address my_ctor_0x101b_6edc { get; } = 0x1007_6e44;
        public static Address my_ctor_0x101b_3acc { get; } = 0x1007_d145;
        public static Address my_ctor_0x101b_56fc { get; } = 0x1008_8c7c;
        public static Address my_ctor_0x101b_3b58 { get; } = 0x1008_b0a4;
        public static Address my_ctor_0x101b_5724 { get; } = 0x100b_9129;
        public static Address my_ctor_0x101b_5750 { get; } = 0x100b_949e;
        public static Address my_ctor_0x101b_5ec8 { get; } = 0x100e_02d4;
        public static Address my_ctor_0x101b_63ec { get; } = 0x1010_471c;
        public static Address my_ctor_0x101b_66dc { get; } = 0x1011_7ce4;
        public static Address my_ctor_0x101b_74f0 { get; } = 0x1016_45d8;

        public static Address my_dtor_d1 { get; } = 0x1008_8cfc;
        public static Address my_dtor_d2 { get; } = 0x100c_e538;
        public static Address my_dtor_d3 { get; } = 0x100d_7d33;
        public static Address my_dtor_d4 { get; } = 0x100d_846d;
        public static Address my_dtor_d5 { get; } = 0x100e_13fa;
        public static Address my_dtor_d6 { get; } = 0x100e_b0d7;
        public static Address my_dtor_d7 { get; } = 0x1011_c242;

        public static Address my_dtor_0x101b_56fc { get; } = 0x1008_8c3c;
        public static Address my_dtor_0x101b_63ec { get; } = 0x1010_4430;
        public static Address my_dtor_0x101b_6edc { get; } = 0x1013_ac45;

        // strobj : 4 - ptr; 2 - size (capaticy, alloc_size) - without '\0'; 2 - len; 4 - ref_count.
        public static Address my_strobj_ctor_capaticy { get; } = 0x1014_1733;
        public static Address my_strobj_ctor_char_ptr { get; } = 0x1014_179c;
        public static Address my_strobj_ctor_strobj { get; } = 0x1014_1816;
        public static Address my_strobj_dtor { get; } = 0x1014_189a;
        // bool arg3 (bl) = 0 - no copy str, 1 - copy str.
        public static Address my_strobj_reserve { get; } = 0x1014_18fd;
        public static Address my_strobj_is_single_ref { get; } = 0x1014_251c;
        public static Address my_strobj_get_size { get; } = 0x1014_255c;
        public static Address my_strobj_get_len { get; } = 0x100e_af24;
        public static Address my_strobj_set_len { get; } = 0x1014_24ec;
        public static Address my_strobj_c_str_v2 { get; } = 0x1008_97c8;
        public static Address my_strobj_c_str { get; } = 0x1008_97fc;

        // make empty string.
        public static Address my_string_ctor { get; } = 0x1014_1ae8;
        public static Address my_string_ctor_capaticy { get; } = 0x1014_19d0;
        public static Address my_string_ctor_char_ptr { get; } = 0x1014_1a3b;
        public static Address my_string_ctor_string { get; } = 0x1014_1aa6;
        public static Address my_string_dtor { get; } = 0x1014_1b2a;
        public static Address my_string_release { get; } = 0x1014_241c;
        public static Address my_string_add_ref { get; } = 0x1014_2464;
        public static Address my_string_make_single_ref { get; } = 0x1014_235c;
        public static Address my_string_clear { get; } = 0x1014_1f15;
        // static
        public static Address my_string_compute_capacity_from_length { get; } = 0x1014_23d8;
        public static Address my_string_reserve { get; } = 0x1014_1b62;
        public static Address my_string_append_string { get; } = 0x1014_1c89;
        public static Address my_string_append_string_v2 { get; } = 0x1014_2494;
        public static Address my_string_append_char_ptr { get; } = 0x1014_1d3f;
        public static Address my_string_append_char { get; } = 0x1014_1dea;
        // char & operator[](int pos)
        public static Address my_string_get { get; } = 0x1014_2292;
        public static Address my_string_strstr_char_ptr { get; } = 0x1014_1e92;
        public static Address my_string_strstr_string { get; } = 0x1014_1ecf;
        public static Address my_string_tolower { get; } = 0x1014_1f63;
        public static Address my_string_toupper { get; } = 0x1014_1fcd;
        // bool arg3 (bl), 0 - case insensitive, 1 - case sensitive.
        public static Address my_string_strcmp { get; } = 0x1014_2170;

        public static Address my_1_get_count { get; } = 0x100a_b4d8;
        public static Address my_2_get_count { get; } = 0x1008_b368;
        public static Address my_3_get_count { get; } = 0x1008_b480;
        public static Address my__get_unit { get; } = 0x100b_801c;

        #endregion

        #region File mve (video)

        public static Address mve_1 { get; } = 0x1018_ea30;
        public static Address mve_2 { get; } = 0x1018_ece8;
        public static Address mve_3 { get; } = 0x1018_f284;
        public static Address mve_4 { get; } = 0x1018_f938;

        #endregion

        #region Res file

        public static Address load_res_file { get; } = 0x1013_4973;

        // size: const (0x787 * 7) bytes,
        // index in this array - id of txt of correspond ptr_arr_meta item.
        // item: { s16 - index of item  ptr_arr_meta, u32 - ptr malloc  data_from_meta?, u8 -  index of  FILE * in arr_res_file }
        public static Address ptr_arr_meta_by_id { get; } = 0x101c_70ec;

        // Начало массива, содержащий FILE * открытых *.RES файлов. Обычно содержит только один файл - MAX.RES.
        public static Address arr_res_file { get; } = 0x101c_70d0;

        // 16 - byte item   { char txt[8]; u32 offset; u32 size }
        public static Address ptr_arr_meta { get; } = 0x101c_70f0;

        // end of ptr_arr_meta.
        public static Address ptr_end_arr_meta { get; } = 0x101c_70da;
        // low byte s8 - end of arr_res_file in term c++,  high s16 of 32 bit value - end of ptr_arr_meta.
        public static Address ptr_end_arr_res_file { get; } = 0x101c_70d8;

        #endregion

        #region System

        public static Address sys_int_21 { get; } = 0x14_f514;
        public static Address sys_int_paging_fault { get; } = 0x13_94f6;

        public static Address sys_int_10 { get; } = 0x1018_7ac2;
        public static Address sys_int_16 { get; } = 0x1018_7ad4;
        public static Address sys_int_31 { get; } = 0x1018_7b25;
        public static Address sys_int_33 { get; } = 0x1018_7b2b;

        public static Address sys_exit { get; } = 0x1016_c65f;
        public static Address sys_check_available_stack_size { get; } = 0x1016_5d52;
        public static Address sys_assert { get; } = 0x1016_5d92;

        public static Address sys_memset { get; } = 0x1016_5de0;
        public static Address sys_memcpy { get; } = 0x1016_5e4b;

        public static Address sys_strcpy { get; } = 0x1016_5ecf;
        public static Address sys_strcat { get; } = 0x1016_5f31;
        public static Address sys_strcmp { get; } = 0x1017_2790;
        public static Address sys_strcasecmp { get; } = 0x1016_6130;
        public static Address sys_strlen { get; } = 0x1017_1ec7;
        public static Address sys_strncpy { get; } = 0x1017_1ee0;
        public static Address sys_strncmp { get; } = 0x1017_915c;
        public static Address sys_strstr { get; } = 0x1017_9010;
        public static Address sys_tolower { get; } = 0x1017_2a95;
        public static Address sys_toupper { get; } = 0x1018_0eea;

        public static Address sys_malloc { get; } = 0x1016_afde;
        public static Address sys_free { get; } = 0x1016_b0c1;

        public static Address sys_new { get; } = 0x1016_5e00;
        public static Address sys_new_arr { get; } = 0x1016_6010;
        public static Address sys_delete { get; } = 0x1016_5f64;
        public static Address sys_delete_arr { get; } = 0x1016_5fd8;

        public static Address sys_malloc_internal { get; } = 0x1018_22f0;
        public static Address sys_free_internal { get; } = 0x1018_2454;
        public static Address sys_check_memory_corrupt { get; } = 0x1018_25e0;
        public static Address sys_free_with_check_memory_corrupt { get; } = 0x1018_245c;

        public static Address sys_sprintf { get; } = 0x1016_5f01;
        public static Address sys_printf { get; } = 0x1016_c63c;

        public static Address sys_fopen_internal { get; } = 0x1016_e7c4;
        public static Address sys_fread_internal { get; } = 0x1016_ea6c;
        public static Address sys_fclose_internal { get; } = 0x1017_0f78;

        public static Address sys_fopen { get; } = 0x1017_237a;
        public static Address sys_fclose { get; } = 0x1017_2069;
        public static Address sys_fread { get; } = 0x1017_256c;
        public static Address sys_fseek { get; } = 0x1017_2470;
        // obtains the current value of the file position
        public static Address sys_ftell { get; } = 0x1017_2747;

        public static Address sys_lseek { get; } = 0x1017_d197;

        public static Address sys_sqrt { get; } = 0x1016_6046;
        public static Address sys_round { get; } = 0x1016_607e;

        public static Address sys_display_apply_palette { get; } = 0x1016_cbbc;
        public static Address sys_display_draw_0 { get; } = 0x1016_7484;
        public static Address sys_display_draw_1 { get; } = 0x1016_74a8;
        public static Address sys_display_draw_2 { get; } = 0x1016_8af0;
        public static Address sys_display_draw_3 { get; } = 0x1016_9814;
        public static Address sys_display_copy_to_video_memory_1 { get; } = 0x1018_cdf4;
        public static Address sys_display_copy_to_video_memory_2 { get; } = 0x1018_d034;

        public static Address sys_call_ctor_arr { get; } = 0x1017_1dff;
        public static Address sys_call_ctor_arr_v2 { get; } = 0x1016_5f70;
        public static Address sys_call_dtor_arr { get; } = 0x1016_5fb8;
        public static Address sys_call_dtor_arr_v2 { get; } = 0x1016_5fe0;

        public static Address sys_timer_1 { get; } = 0x1018_dc3c;
        public static Address sys_timer_2 { get; } = 0x1018_dc67;
        public static Address sys_timer_3 { get; } = 0x1018_dcc4;
        public static Address sys_timer_4 { get; } = 0x1018_dd02;

        public static Address sys_read_port { get; } = 0x1018_0fd2;
        public static Address sys_write_port { get; } = 0x1018_0fc8;

        public static Address sys_cli { get; } = 0x1018_0fda;
        public static Address sys_sti { get; } = 0x1018_0fdc;

        #endregion

        #region Video

        public static Address ptr_to_pallete { get; } = 0x101c_9464;

        public static Address video_bytes_per_line { get; } = 0x1020_9c98; // 640
        public static Address video_bank_count_in_win { get; } = 0x1020_9c9c; // 1
        public static Address video_win_len { get; } = 0x1020_9ca0; // 0x10000

        // video_win_granularity -
        // Минимальное расстояние между двумя адресами в видеопамяти, которые могут отображаться
        // на один и тот же адрес в окне, называется granularity (от английского granulate - дробить).
        // Размер окна (или банка) должен быть большим или равным granularity. Если мы разделим
        // абсолютный адрес в видеопамяти на granularity, то частным будет номер банка, а остатком -
        // смещение относительно начала окна.
        public static Address video_win_granularity { get; } = 0x1020_9ca4; // 0x10000
        public static Address video_win_start { get; } = 0x1020_9ca8; // 0xa0000
        public static Address video_win_start_v2 { get; } = 0x1020_8918; // 0xa0000
        public static Address video_win_end { get; } = 0x1020_9cac; // 0xb0000 = video_win_start + video_win_len
        public static Address ptr_of_fd_table_ { get; } = 0x101c_0a24;

        #endregion

        #region Misc


        #endregion
    }
}

#pragma warning restore IDE1006 // Naming Styles
