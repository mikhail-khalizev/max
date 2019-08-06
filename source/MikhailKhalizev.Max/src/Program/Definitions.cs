// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming Styles

using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.Core.Abstractions;

namespace MikhailKhalizev.Max.Program
{
    public partial class Definitions
    {
        #region My
        
        public static Address my_main { get; } = 0x1010883e;
        public static Address my_min { get; } = 0x10089784;
        public static Address my_fopen { get; } = 0x100ef41f;
        public static Address my_fseek { get; } = 0x100ef455;
        public static Address my_fread { get; } = 0x100ef48f;

        public static Address my_play_video_company { get; } = 0x101157ff;
        // Анимация карты при запуске ?
        public static Address my_game_map_start_animation { get; } = 0x100fded4;

        public static Address my_get_res_data_by_id { get; } = 0x10133fd8;
        public static Address my_get_res_data_by_id_malloc { get; } = 0x101341eb;

        public static Address my_set_al_1 { get; } = 0x101424cc;
        public static Address my_set_al_1_v2 { get; } = 0x10102b40;

        public static Address my_ctor_c1 { get; } = 0x1007abdb;
        public static Address my_ctor_c2 { get; } = 0x1008caea;
        public static Address my_ctor_c3 { get; } = 0x10098852;
        public static Address my_ctor_c4 { get; } = 0x10099662;
        public static Address my_ctor_c5 { get; } = 0x10099918;
        public static Address my_ctor_c6 { get; } = 0x10099b88;
        public static Address my_ctor_c7 { get; } = 0x10099d3d;
        public static Address my_ctor_c8 { get; } = 0x10099ee1;
        public static Address my_ctor_c9 { get; } = 0x1009d12a;
        public static Address my_ctor_c10 { get; } = 0x100e9096;
        public static Address my_ctor_c11 { get; } = 0x100a38c9;
        public static Address my_ctor_c12 { get; } = 0x100a606c;
        public static Address my_ctor_c13 { get; } = 0x100a764f;
        public static Address my_ctor_c14 { get; } = 0x100b8cbf;
        public static Address my_ctor_c15 { get; } = 0x100cb888;
        public static Address my_ctor_c16 { get; } = 0x100cce2a;
        public static Address my_ctor_c17 { get; } = 0x100ce40f;
        public static Address my_ctor_c18 { get; } = 0x100cd35d;
        public static Address my_ctor_c19 { get; } = 0x100d7c5e;
        public static Address my_ctor_c20 { get; } = 0x10119f56;
        public static Address my_ctor_c21 { get; } = 0x101416cc;

        public static Address my_ctor_0x101b38f8 { get; } = 0x100766f0;
        public static Address my_ctor_0x101b4184 { get; } = 0x10076af0;
        public static Address my_ctor_0x101b38d0 { get; } = 0x10076844;
        public static Address my_ctor_0x101b6edc { get; } = 0x10076e44;
        public static Address my_ctor_0x101b3acc { get; } = 0x1007d145;
        public static Address my_ctor_0x101b56fc { get; } = 0x10088c7c;
        public static Address my_ctor_0x101b3b58 { get; } = 0x1008b0a4;
        public static Address my_ctor_0x101b5724 { get; } = 0x100b9129;
        public static Address my_ctor_0x101b5750 { get; } = 0x100b949e;
        public static Address my_ctor_0x101b5ec8 { get; } = 0x100e02d4;
        public static Address my_ctor_0x101b63ec { get; } = 0x1010471c;
        public static Address my_ctor_0x101b66dc { get; } = 0x10117ce4;
        public static Address my_ctor_0x101b74f0 { get; } = 0x101645d8;

        public static Address my_dtor_d1 { get; } = 0x10088cfc;
        public static Address my_dtor_d2 { get; } = 0x100ce538;
        public static Address my_dtor_d3 { get; } = 0x100d7d33;
        public static Address my_dtor_d4 { get; } = 0x100d846d;
        public static Address my_dtor_d5 { get; } = 0x100e13fa;
        public static Address my_dtor_d6 { get; } = 0x100eb0d7;
        public static Address my_dtor_d7 { get; } = 0x1011c242;

        public static Address my_dtor_0x101b56fc { get; } = 0x10088c3c;
        public static Address my_dtor_0x101b63ec { get; } = 0x10104430;
        public static Address my_dtor_0x101b6edc { get; } = 0x1013ac45;

        // strobj : 4 - ptr; 2 - size (capaticy, alloc_size) - without '\0'; 2 - len; 4 - ref_count.
        public static Address my_strobj_ctor_capaticy { get; } = 0x10141733;
        public static Address my_strobj_ctor_char_ptr { get; } = 0x1014179c;
        public static Address my_strobj_ctor_strobj { get; } = 0x10141816;
        public static Address my_strobj_dtor { get; } = 0x1014189a;
        // bool arg3 (bl) = 0 - no copy str, 1 - copy str.
        public static Address my_strobj_reserve { get; } = 0x101418fd;
        public static Address my_strobj_is_single_ref { get; } = 0x1014251c;
        public static Address my_strobj_get_size { get; } = 0x1014255c;
        public static Address my_strobj_get_len { get; } = 0x100eaf24;
        public static Address my_strobj_set_len { get; } = 0x101424ec;
        public static Address my_strobj_c_str_v2 { get; } = 0x100897c8;
        public static Address my_strobj_c_str { get; } = 0x100897fc;

        // make empty string.
        public static Address my_string_ctor { get; } = 0x10141ae8;
        public static Address my_string_ctor_capaticy { get; } = 0x101419d0;
        public static Address my_string_ctor_char_ptr { get; } = 0x10141a3b;
        public static Address my_string_ctor_string { get; } = 0x10141aa6;
        public static Address my_string_dtor { get; } = 0x10141b2a;
        public static Address my_string_release { get; } = 0x1014241c;
        public static Address my_string_add_ref { get; } = 0x10142464;
        public static Address my_string_make_single_ref { get; } = 0x1014235c;
        public static Address my_string_clear { get; } = 0x10141f15;
        // static
        public static Address my_string_compute_capacity_from_length { get; } = 0x101423d8;
        public static Address my_string_reserve { get; } = 0x10141b62;
        public static Address my_string_append_string { get; } = 0x10141c89;
        public static Address my_string_append_string_v2 { get; } = 0x10142494;
        public static Address my_string_append_char_ptr { get; } = 0x10141d3f;
        public static Address my_string_append_char { get; } = 0x10141dea;
        // char & operator[](int pos)
        public static Address my_string_get { get; } = 0x10142292;
        public static Address my_string_strstr_char_ptr { get; } = 0x10141e92;
        public static Address my_string_strstr_string { get; } = 0x10141ecf;
        public static Address my_string_tolower { get; } = 0x10141f63;
        public static Address my_string_toupper { get; } = 0x10141fcd;
        // bool arg3 (bl), 0 - case insensitive, 1 - case sensitive.
        public static Address my_string_strcmp { get; } = 0x10142170;

        public static Address my_1_get_count { get; } = 0x100ab4d8;
        public static Address my_2_get_count { get; } = 0x1008b368;
        public static Address my_3_get_count { get; } = 0x1008b480;
        public static Address my__get_unit { get; } = 0x100b801c;

        #endregion

        #region Res file

        public static Address load_res_file { get; } = 0x10134973;

        // size: const (0x787 * 7) bytes,
        // index in this array - id of txt of correspond ptr_arr_meta item.
        // item: { s16 - index of item  ptr_arr_meta, u32 - ptr malloc  data_from_meta?, u8 -  index of  FILE * in arr_res_file }
        public static Address ptr_arr_meta_by_id { get; } = 0x101c70ec;

        // Начало массива, содержащий FILE * открытых *.RES файлов. Обычно содержит только один файл - MAX.RES.
        public static Address arr_res_file { get; } = 0x101c70d0;

        // 16 - byte item   { char txt[8]; u32 offset; u32 size }
        public static Address ptr_arr_meta { get; } = 0x101c70f0;

        // end of ptr_arr_meta.
        public static Address ptr_end_arr_meta { get; } = 0x101c70da;
        // low byte s8 - end of arr_res_file in term c++,  high s16 of 32 bit value - end of ptr_arr_meta.
        public static Address ptr_end_arr_res_file { get; } = 0x101c70d8;

        #endregion

        #region System

        public static Address sys_int_10 { get; } = 0x10187ac2;
        public static Address sys_int_16 { get; } = 0x10187ad4;
        public static Address sys_int_31 { get; } = 0x10187b25;
        public static Address sys_int_33 { get; } = 0x10187b2b;

        public static Address sys_exit { get; } = 0x1016c65f;
        public static Address sys_check_available_stack_size { get; } = 0x10165d52;
        public static Address sys_assert { get; } = 0x10165d92;

        public static Address sys_memset { get; } = 0x10165de0;
        public static Address sys_memcpy { get; } = 0x10165e4b;

        public static Address sys_strcpy { get; } = 0x10165ecf;
        public static Address sys_strcat { get; } = 0x10165f31;
        public static Address sys_strcmp { get; } = 0x10172790;
        public static Address sys_strcasecmp { get; } = 0x10166130;
        public static Address sys_strlen { get; } = 0x10171ec7;
        public static Address sys_strncpy { get; } = 0x10171ee0;
        public static Address sys_strncmp { get; } = 0x1017915c;
        public static Address sys_strstr { get; } = 0x10179010;
        public static Address sys_toupper { get; } = 0x10180eea;
        public static Address sys_tolower { get; } = 0x10172a95;

        public static Address sys_malloc { get; } = 0x1016afde;
        public static Address sys_free { get; } = 0x1016b0c1;

        public static Address sys_new { get; } = 0x10165e00;
        public static Address sys_new_arr { get; } = 0x10166010;
        public static Address sys_delete { get; } = 0x10165f64;
        public static Address sys_delete_arr { get; } = 0x10165fd8;

        public static Address sys_malloc_internal { get; } = 0x101822f0;
        public static Address sys_free_internal { get; } = 0x10182454;
        public static Address sys_check_memory_corrupt { get; } = 0x101825e0;
        public static Address sys_free_with_check_memory_corrupt { get; } = 0x1018245c;

        public static Address sys_sprintf { get; } = 0x10165f01;
        public static Address sys_printf { get; } = 0x1016c63c;

        public static Address sys_fopen_internal { get; } = 0x1016e7c4;
        public static Address sys_fread_internal { get; } = 0x1016ea6c;
        public static Address sys_fclose_internal { get; } = 0x10170f78;

        public static Address sys_fopen { get; } = 0x1017237a;
        public static Address sys_fclose { get; } = 0x10172069;
        public static Address sys_fread { get; } = 0x1017256c;
        public static Address sys_fseek { get; } = 0x10172470;
        // obtains the current value of the file position
        public static Address sys_ftell { get; } = 0x10172747;

        public static Address sys_lseek { get; } = 0x1017d197;

        public static Address sys_sqrt { get; } = 0x10166046;
        public static Address sys_round { get; } = 0x1016607e;

        public static Address sys_display_apply_palette { get; } = 0x1016cbbc;
        public static Address sys_display_draw_0 { get; } = 0x10167484;
        public static Address sys_display_draw_1 { get; } = 0x101674a8;
        public static Address sys_display_draw_2 { get; } = 0x10168af0;
        public static Address sys_display_draw_3 { get; } = 0x10169814;
        public static Address sys_display_copy_to_video_memory_1 { get; } = 0x1018cdf4;
        public static Address sys_display_copy_to_video_memory_2 { get; } = 0x1018d034;

        public static Address sys_call_ctor_arr { get; } = 0x10171dff;
        public static Address sys_call_ctor_arr_v2 { get; } = 0x10165f70;
        public static Address sys_call_dtor_arr { get; } = 0x10165fb8;
        public static Address sys_call_dtor_arr_v2 { get; } = 0x10165fe0;

        #endregion

        #region Some variable

        public static Address ptr_to_pallete { get; } = 0x101c9464;

        public static Address video_bytes_per_line { get; } = 0x10209c98; // 640
        public static Address video_bank_count_in_win { get; } = 0x10209c9c; // 1
        public static Address video_win_len { get; } = 0x10209ca0; // 0x10000

        // video_win_granularity -
        // Минимальное расстояние между двумя адресами в видеопамяти, которые могут отображаться
        // на один и тот же адрес в окне, называется granularity (от английского granulate - дробить).
        // Размер окна (или банка) должен быть большим или равным granularity. Если мы разделим
        // абсолютный адрес в видеопамяти на granularity, то частным будет номер банка, а остатком -
        // смещение относительно начала окна.
        public static Address video_win_granularity { get; } = 0x10209ca4; // 0x10000
        public static Address video_win_start { get; } = 0x10209ca8; // 0xa0000
        public static Address video_win_start_v2 { get; } = 0x10208918; // 0xa0000
        public static Address video_win_end { get; } = 0x10209cac; // 0xb0000 = video_win_start + video_win_len
        public static Address ptr_of_fd_table_ { get; } = 0x101c0a24;

        #endregion
    }
}

#pragma warning restore IDE1006 // Naming Styles
