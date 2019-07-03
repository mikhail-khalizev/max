/* my */

CALL(0x1010883e, my_main)
CALL(0x10089784, my_min)
CALL(0x100ef41f, my_fopen)
CALL(0x100ef455, my_fseek)
CALL(0x100ef48f, my_fread)

CALL(0x101157ff, my_play_video_company)
CALL(0x100fded4, my_game_map_start_animatioin) // Анимация карты при запуске ?

CALL(0x10133fd8, my_get_res_data_by_id)
CALL(0x101341eb, my_get_res_data_by_id_malloc)

CALL(0x101424cc, my_set_al_1)
CALL(0x10102b40, my_set_al_1_v2)

CALL(0x1007abdb, my_ctor_c1)
CALL(0x1008caea, my_ctor_c2)
CALL(0x10098852, my_ctor_c3)
CALL(0x10099662, my_ctor_c4)
CALL(0x10099918, my_ctor_c5)
CALL(0x10099b88, my_ctor_c6)
CALL(0x10099d3d, my_ctor_c7)
CALL(0x10099ee1, my_ctor_c8)
CALL(0x1009d12a, my_ctor_c9)
CALL(0x100e9096, my_ctor_c10)
CALL(0x100a38c9, my_ctor_c11)
CALL(0x100a606c, my_ctor_c12)
CALL(0x100a764f, my_ctor_c13)
CALL(0x100b8cbf, my_ctor_c14)
CALL(0x100cb888, my_ctor_c15)
CALL(0x100cce2a, my_ctor_c16)
CALL(0x100ce40f, my_ctor_c17)
CALL(0x100cd35d, my_ctor_c18)
CALL(0x100d7c5e, my_ctor_c19)
CALL(0x10119f56, my_ctor_c20)
CALL(0x101416cc, my_ctor_c21)

CALL(0x100766f0, my_ctor_0x101b38f8)
CALL(0x10076af0, my_ctor_0x101b4184)
CALL(0x10076844, my_ctor_0x101b38d0)
CALL(0x10076e44, my_ctor_0x101b6edc)
CALL(0x1007d145, my_ctor_0x101b3acc)
CALL(0x10088c7c, my_ctor_0x101b56fc)
CALL(0x1008b0a4, my_ctor_0x101b3b58)
CALL(0x100b9129, my_ctor_0x101b5724)
CALL(0x100b949e, my_ctor_0x101b5750)
CALL(0x100e02d4, my_ctor_0x101b5ec8)
CALL(0x1010471c, my_ctor_0x101b63ec)
CALL(0x10117ce4, my_ctor_0x101b66dc)
CALL(0x101645d8, my_ctor_0x101b74f0)

CALL(0x10088cfc, my_dtor_d1)
CALL(0x100ce538, my_dtor_d2)
CALL(0x100d7d33, my_dtor_d3)
CALL(0x100d846d, my_dtor_d4)
CALL(0x100e13fa, my_dtor_d5)
CALL(0x100eb0d7, my_dtor_d6)
CALL(0x1011c242, my_dtor_d7)

CALL(0x10088c3c, my_dtor_0x101b56fc)
CALL(0x10104430, my_dtor_0x101b63ec)
CALL(0x1013ac45, my_dtor_0x101b6edc)

// strobj : 4 - ptr; 2 - size (capaticy, alloc_size) - without '\0'; 2 - len; 4 - ref_count.
CALL(0x10141733, my_strobj_ctor_capaticy)
CALL(0x1014179c, my_strobj_ctor_char_ptr)
CALL(0x10141816, my_strobj_ctor_strobj)
CALL(0x1014189a, my_strobj_dtor)
CALL(0x101418fd, my_strobj_reserve)   // bool arg3 (bl) = 0 - no copy str, 1 - copy str.
CALL(0x1014251c, my_strobj_is_single_ref)
CALL(0x1014255c, my_strobj_get_size)
CALL(0x100eaf24, my_strobj_get_len)
CALL(0x101424ec, my_strobj_set_len)
CALL(0x100897c8, my_strobj_c_str_v2)
CALL(0x100897fc, my_strobj_c_str)

CALL(0x10141ae8, my_string_ctor) // make empty string.
CALL(0x101419d0, my_string_ctor_capaticy)
CALL(0x10141a3b, my_string_ctor_char_ptr)
CALL(0x10141aa6, my_string_ctor_string)
CALL(0x10141b2a, my_string_dtor)
CALL(0x1014241c, my_string_release)
CALL(0x10142464, my_string_add_ref)
CALL(0x1014235c, my_string_make_single_ref)
CALL(0x10141f15, my_string_clear)
CALL(0x101423d8, my_string_compute_capacity_from_length) // static
CALL(0x10141b62, my_string_reserve)
CALL(0x10141c89, my_string_append_string)
CALL(0x10142494, my_string_append_string_v2)
CALL(0x10141d3f, my_string_append_char_ptr)
CALL(0x10141dea, my_string_append_char)
CALL(0x10142292, my_string_get) // char & operator[](int pos)
CALL(0x10141e92, my_string_strstr_char_ptr)
CALL(0x10141ecf, my_string_strstr_string)
CALL(0x10141f63, my_string_tolower)
CALL(0x10141fcd, my_string_toupper)
CALL(0x10142170, my_string_strcmp) // bool arg3 (bl), 0 - case insensitive, 1 - case sensitive.

CALL(0x100ab4d8, my_1_get_count)
CALL(0x1008b368, my_2_get_count)
CALL(0x1008b480, my_3_get_count)
CALL(0x100b801c, my__get_unit)

/* res file */

CALL(0x10134973, load_res_file)

/* size: const (0x787 * 7) bytes,
 * index in this array - id of txt of correspond ptr_arr_meta item.
 * item: { s16 - index of item  ptr_arr_meta, u32 - ptr malloc  data_from_meta?, u8 -  index of  FILE * in arr_res_file }  */
VARIABLE(0x101c70ec, ptr_arr_meta_by_id)
VARIABLE(0x101c70d0, arr_res_file) /* Начало массива, содержащий FILE * открытых *.RES файлов. Обычно содержит только один файл - MAX.RES. */
VARIABLE(0x101c70f0, ptr_arr_meta) /* 16 - byte item   { char txt[8]; u32 offset; u32 size } */
VARIABLE(0x101c70da, ptr_end_arr_meta) /* end of ptr_arr_meta. */
VARIABLE(0x101c70d8, ptr_end_arr_res_file) /* low byte s8 - end of arr_res_file in term c++,  high s16 of 32 bit value - end of ptr_arr_meta. */


/* sys */

CALL(0x10187ac2, sys_int_10)
CALL(0x10187ad4, sys_int_16)
CALL(0x10187b25, sys_int_31)
CALL(0x10187b2b, sys_int_33)

CALL(0x1016c65f, sys_exit)
CALL(0x10165d52, sys_check_available_stack_size)
CALL(0x10165d92, sys_assert)

CALL(0x10165de0, sys_memset)
CALL(0x10165e4b, sys_memcpy)

CALL(0x10165ecf, sys_strcpy)
CALL(0x10165f31, sys_strcat)
CALL(0x10172790, sys_strcmp)
CALL(0x10166130, sys_strcasecmp)
CALL(0x10171ec7, sys_strlen)
CALL(0x10171ee0, sys_strncpy)
CALL(0x1017915c, sys_strncmp)
CALL(0x10179010, sys_strstr)
CALL(0x10180eea, sys_toupper)
CALL(0x10172a95, sys_tolower)

CALL(0x1016afde, sys_malloc)
CALL(0x1016b0c1, sys_free)

CALL(0x10165e00, sys_new)
CALL(0x10166010, sys_new_arr)
CALL(0x10165f64, sys_delete)
CALL(0x10165fd8, sys_delete_arr)

CALL(0x101822f0, sys_malloc_internal)
CALL(0x10182454, sys_free_internal)
CALL(0x101825e0, sys_check_memory_corrupt)
CALL(0x1018245c, sys_free_with_check_memory_corrupt)

CALL(0x10165f01, sys_sprintf)
CALL(0x1016c63c, sys_printf)

CALL(0x1016e7c4, sys_fopen_internal)
CALL(0x1016ea6c, sys_fread_internal)
CALL(0x10170f78, sys_fclose_internal)

CALL(0x1017237a, sys_fopen)
CALL(0x10172069, sys_fclose)
CALL(0x1017256c, sys_fread)
CALL(0x10172470, sys_fseek)
CALL(0x10172747, sys_ftell) // obtains the current value of the file position

CALL(0x1017d197, sys_lseek)

CALL(0x10166046, sys_sqrt)
CALL(0x1016607e, sys_round)

CALL(0x1016cbbc, sys_display_applay_palette)
CALL(0x10167484, sys_display_draw_0)
CALL(0x101674a8, sys_display_draw_1)
CALL(0x10168af0, sys_display_draw_2)
CALL(0x10169814, sys_display_draw_3)
CALL(0x1018cdf4, sys_display_copy_to_video_memory_1)
CALL(0x1018d034, sys_display_copy_to_video_memory_2)

CALL(0x10171dff, sys_call_ctor_arr)
CALL(0x10165f70, sys_call_ctor_arr_v2)
CALL(0x10165fb8, sys_call_dtor_arr)
CALL(0x10165fe0, sys_call_dtor_arr_v2)

/* Some variable */

VARIABLE(0x101c9464, ptr_to_pallete)

VARIABLE(0x10209c98, video_bytes_per_line)  // 640
VARIABLE(0x10209c9c, video_bank_count_in_win)  // 1
VARIABLE(0x10209ca0, video_win_len) // 0x10000
/* video_win_granularity -
 * Минимальное расстояние между двумя адресами в видеопамяти, которые могут отображаться
 * на один и тот же адрес в окне, называется granularity (от английского granulate - дробить).
 * Размер окна (или банка) должен быть большим или равным granularity. Если мы разделим
 * абсолютный адрес в видеопамяти на granularity, то частным будет номер банка, а остатком -
 * смещение относительно начала окна */
VARIABLE(0x10209ca4, video_win_granularity) // 0x10000
VARIABLE(0x10209ca8, video_win_start) // 0xa0000
VARIABLE(0x10208918, video_win_start_v2) // 0xa0000
VARIABLE(0x10209cac, video_win_end) // 0xb0000 = video_win_start + video_win_len

VARIABLE(0x101c0a24, ptr_of_fd_table_)
