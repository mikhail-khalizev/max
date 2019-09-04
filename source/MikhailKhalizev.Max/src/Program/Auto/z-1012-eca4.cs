using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_eca4-4d65c28")]
        public void Method_1012_eca4()
        {
            ii(0x1012_eca4, 5);  push(0x94);                           /* push 0x94 */
            ii(0x1012_eca9, 5);  call(Definitions.sys_check_available_stack_size, 0x3_70a4);/* call 0x10165d52 */
            ii(0x1012_ecae, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_ecaf, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_ecb0, 1);  push(edx);                            /* push edx */
            ii(0x1012_ecb1, 1);  push(esi);                            /* push esi */
            ii(0x1012_ecb2, 1);  push(edi);                            /* push edi */
            ii(0x1012_ecb3, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_ecb4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_ecb6, 6);  sub(esp, 0x78);                       /* sub esp, 0x78 */
            ii(0x1012_ecbc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_ecbf, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1012_ecc1, 5);  mov(al, memb[ds, 0x101c_37da]);       /* mov al, [0x101c37da] */
            ii(0x1012_ecc6, 3);  imul(eax, eax, 0xa);                  /* imul eax, eax, 0xa */
            ii(0x1012_ecc9, 5);  mov(edx, 0x101c_52bc);                /* mov edx, 0x101c52bc */
            ii(0x1012_ecce, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_ecd0, 5);  call(0x1011_7c6c, -0x1_7069);         /* call 0x10117c6c */
            ii(0x1012_ecd5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_ecd7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ecda, 5);  call(0x1013_1b6c, 0x2e8d);            /* call 0x10131b6c */
            ii(0x1012_ecdf, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1012_ece3, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1012_ece9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_eceb, 6);  call_abs(memd[ds, 0x101b_ddf0]);      /* call dword [0x101bddf0] */
            ii(0x1012_ecf1, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1012_ecf3, 3);  add(edx, 0x1f);                       /* add edx, 0x1f */
            ii(0x1012_ecf6, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_ecf8, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_ecfb, 2);  idiv(ebx);                            /* idiv ebx */
            ii(0x1012_ecfd, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_ed00, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ed03, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_ed06, 5);  call(0x1013_b325, 0xc61a);            /* call 0x1013b325 */
            ii(0x1012_ed0b, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x1012_ed10, 5);  call(/* sys */ 0x1016_a24c, 0x3_b537);/* call 0x1016a24c */
            ii(0x1012_ed15, 2);  jmp(0x1012_ed1f, 8); goto l_0x1012_ed1f;/* jmp 0x1012ed1f */
        l_0x1012_ed17:
            ii(0x1012_ed17, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ed1a, 5);  call(0x1007_6bf8, -0xb_8127);         /* call 0x10076bf8 */
        l_0x1012_ed1f:
            ii(0x1012_ed1f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_ed21, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ed24, 5);  call(0x1013_ad71, 0xc048);            /* call 0x1013ad71 */
            ii(0x1012_ed29, 2);  test(al, al);                         /* test al, al */
            ii(0x1012_ed2b, 6);  if(jz(0x1012_efb0, 0x27f)) goto l_0x1012_efb0;/* jz 0x1012efb0 */
            ii(0x1012_ed31, 3);  lea(ecx, memd[ss, ebp - 16]);         /* lea ecx, [ebp-0x10] */
            ii(0x1012_ed34, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ed37, 6);  mov(eax, memd[ds, eax + 222]);        /* mov eax, [eax+0xde] */
            ii(0x1012_ed3d, 5);  call(0x100d_4f58, -0x5_9dea);         /* call 0x100d4f58 */
            ii(0x1012_ed42, 3);  sub(eax, 0x5f);                       /* sub eax, 0x5f */
            ii(0x1012_ed45, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x1012_ed48, 5);  mov(edx, 0x64);                       /* mov edx, 0x64 */
            ii(0x1012_ed4d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ed50, 5);  call(0x1011_7d24, -0x1_7031);         /* call 0x10117d24 */
            ii(0x1012_ed55, 5);  call(0x1013_1ad4, 0x2d7a);            /* call 0x10131ad4 */
            ii(0x1012_ed5a, 5);  call(0x100e_969d, -0x4_56c2);         /* call 0x100e969d */
            ii(0x1012_ed5f, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1012_ed62, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1012_ed66, 6);  if(jz(0x1012_efab, 0x23f)) goto l_0x1012_efab;/* jz 0x1012efab */
            ii(0x1012_ed6c, 4);  cmp(memb[ss, ebp - 8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x1012_ed70, 2);  if(jnz(0x1012_eddb, 0x69)) goto l_0x1012_eddb;/* jnz 0x1012eddb */
            ii(0x1012_ed72, 5);  call(0x1013_19ac, 0x2c35);            /* call 0x101319ac */
            ii(0x1012_ed77, 1);  cwde();                               /* cwde */
            ii(0x1012_ed78, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1012_ed7b, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1012_ed80, 5);  call(Definitions.sys_new, 0x3_707b);  /* call 0x10165e00 */
            ii(0x1012_ed85, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_ed88, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1012_ed8b, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1012_ed8e, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1012_ed92, 2);  if(jz(0x1012_edba, 0x26)) goto l_0x1012_edba;/* jz 0x1012edba */
            ii(0x1012_ed94, 5);  mov(edx, StringDefinitions.Empty4);   /* mov edx, 0x101a87eb */
            ii(0x1012_ed99, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_ed9c, 5);  call(Definitions.my_string_ctor_char_ptr, 0x1_2c9a);/* call 0x10141a3b */
            ii(0x1012_eda1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_eda3, 3);  mov(ecx, memd[ss, ebp - 36]);         /* mov ecx, [ebp-0x24] */
            ii(0x1012_eda6, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1012_eda8, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1012_edaa, 5);  call(0x1013_1716, 0x2967);            /* call 0x10131716 */
            ii(0x1012_edaf, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1012_edb2, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_edb5, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1012_edb8, 2);  jmp(0x1012_edc0, 6); goto l_0x1012_edc0;/* jmp 0x1012edc0 */
        l_0x1012_edba:
            ii(0x1012_edba, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1012_edbd, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x1012_edc0:
            ii(0x1012_edc0, 3);  mov(edx, memd[ss, ebp - 52]);         /* mov edx, [ebp-0x34] */
            ii(0x1012_edc3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_edc6, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_edc9, 3);  mov(ebx, memd[ss, ebp - 32]);         /* mov ebx, [ebp-0x20] */
            ii(0x1012_edcc, 5);  call(0x1013_18c0, 0x2aef);            /* call 0x101318c0 */
            ii(0x1012_edd1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_edd3, 3);  lea(eax, memd[ss, ebp - 44]);         /* lea eax, [ebp-0x2c] */
            ii(0x1012_edd6, 5);  call(Definitions.my_string_dtor, 0x1_2d4f);/* call 0x10141b2a */
        l_0x1012_eddb:
            ii(0x1012_eddb, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1012_eddf, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_ede6, 2);  jmp(0x1012_edee, 6); goto l_0x1012_edee;/* jmp 0x1012edee */
        l_0x1012_ede8:
            ii(0x1012_ede8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_edeb, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1012_edee:
            ii(0x1012_edee, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_edf2, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_edf6, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_edf8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_edfa, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_edfc, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_edff, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_ee01, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1012_ee03, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_ee07, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1012_ee09, 2);  if(jge(0x1012_ee7f, 0x74)) goto l_0x1012_ee7f;/* jge 0x1012ee7f */
            ii(0x1012_ee0b, 5);  call(0x1013_19ac, 0x2b9c);            /* call 0x101319ac */
            ii(0x1012_ee10, 1);  cwde();                               /* cwde */
            ii(0x1012_ee11, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1012_ee14, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1012_ee19, 5);  call(Definitions.sys_new, 0x3_6fe2);  /* call 0x10165e00 */
            ii(0x1012_ee1e, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1012_ee21, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_ee24, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1012_ee27, 4);  cmp(memd[ss, ebp - 64], 0);           /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1012_ee2b, 2);  if(jz(0x1012_ee59, 0x2c)) goto l_0x1012_ee59;/* jz 0x1012ee59 */
            ii(0x1012_ee2d, 5);  mov(edx, StringDefinitions.Empty5);   /* mov edx, 0x101a87ec */
            ii(0x1012_ee32, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1012_ee35, 5);  call(Definitions.my_string_ctor_char_ptr, 0x1_2c01);/* call 0x10141a3b */
            ii(0x1012_ee3a, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1012_ee3c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ee3f, 5);  call(0x1013_1b38, 0x2cf4);            /* call 0x10131b38 */
            ii(0x1012_ee44, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_ee46, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_ee49, 5);  call(0x1013_1716, 0x28c8);            /* call 0x10131716 */
            ii(0x1012_ee4e, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1012_ee51, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1012_ee54, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1012_ee57, 2);  jmp(0x1012_ee5f, 6); goto l_0x1012_ee5f;/* jmp 0x1012ee5f */
        l_0x1012_ee59:
            ii(0x1012_ee59, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1012_ee5c, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
        l_0x1012_ee5f:
            ii(0x1012_ee5f, 3);  mov(edx, memd[ss, ebp - 76]);         /* mov edx, [ebp-0x4c] */
            ii(0x1012_ee62, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ee65, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_ee68, 3);  mov(ebx, memd[ss, ebp - 56]);         /* mov ebx, [ebp-0x38] */
            ii(0x1012_ee6b, 5);  call(0x1013_18c0, 0x2a50);            /* call 0x101318c0 */
            ii(0x1012_ee70, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_ee72, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1012_ee75, 5);  call(Definitions.my_string_dtor, 0x1_2cb0);/* call 0x10141b2a */
            ii(0x1012_ee7a, 5);  jmp(0x1012_ede8, -0x97); goto l_0x1012_ede8;/* jmp 0x1012ede8 */
        l_0x1012_ee7f:
            ii(0x1012_ee7f, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_ee86, 2);  jmp(0x1012_ee8e, 6); goto l_0x1012_ee8e;/* jmp 0x1012ee8e */
        l_0x1012_ee88:
            ii(0x1012_ee88, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_ee8b, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1012_ee8e:
            ii(0x1012_ee8e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_ee91, 4);  cmp(ax, memw[ss, ebp - 16]);          /* cmp ax, [ebp-0x10] */
            ii(0x1012_ee95, 2);  if(jge(0x1012_eefb, 0x64)) goto l_0x1012_eefb;/* jge 0x1012eefb */
            ii(0x1012_ee97, 5);  call(0x1013_19ac, 0x2b10);            /* call 0x101319ac */
            ii(0x1012_ee9c, 1);  cwde();                               /* cwde */
            ii(0x1012_ee9d, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1012_eea0, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1012_eea5, 5);  call(Definitions.sys_new, 0x3_6f56);  /* call 0x10165e00 */
            ii(0x1012_eeaa, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1012_eead, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1012_eeb0, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x1012_eeb3, 4);  cmp(memd[ss, ebp - 88], 0);           /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1012_eeb7, 2);  if(jz(0x1012_eee2, 0x29)) goto l_0x1012_eee2;/* jz 0x1012eee2 */
            ii(0x1012_eeb9, 4);  movsx(ebx, memw[ss, ebp - 12]);       /* movsx ebx, word [ebp-0xc] */
            ii(0x1012_eebd, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x1012_eec0, 3);  add(ebx, memd[ss, ebp - 28]);         /* add ebx, [ebp-0x1c] */
            ii(0x1012_eec3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_eec6, 5);  call(0x1013_1b38, 0x2c6d);            /* call 0x10131b38 */
            ii(0x1012_eecb, 3);  mov(ecx, memd[ss, ebp - 84]);         /* mov ecx, [ebp-0x54] */
            ii(0x1012_eece, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_eed0, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1012_eed2, 5);  call(0x1013_1716, 0x283f);            /* call 0x10131716 */
            ii(0x1012_eed7, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1012_eeda, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x1012_eedd, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x1012_eee0, 2);  jmp(0x1012_eee8, 6); goto l_0x1012_eee8;/* jmp 0x1012eee8 */
        l_0x1012_eee2:
            ii(0x1012_eee2, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1012_eee5, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
        l_0x1012_eee8:
            ii(0x1012_eee8, 3);  mov(edx, memd[ss, ebp - 96]);         /* mov edx, [ebp-0x60] */
            ii(0x1012_eeeb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_eeee, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_eef1, 3);  mov(ebx, memd[ss, ebp - 80]);         /* mov ebx, [ebp-0x50] */
            ii(0x1012_eef4, 5);  call(0x1013_18c0, 0x29c7);            /* call 0x101318c0 */
            ii(0x1012_eef9, 2);  jmp(0x1012_ee88, -0x73); goto l_0x1012_ee88;/* jmp 0x1012ee88 */
        l_0x1012_eefb:
            ii(0x1012_eefb, 4);  movsx(edx, memw[ss, ebp - 20]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_eeff, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1012_ef03, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x1012_ef05, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1012_ef07, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x1012_ef0a, 2);  sub(eax, edx);                        /* sub eax, edx */
            ii(0x1012_ef0c, 2);  sar(eax, 1);                          /* sar eax, 1 */
            ii(0x1012_ef0e, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1012_ef12, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x1012_ef14, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_ef17, 2);  jmp(0x1012_ef1f, 6); goto l_0x1012_ef1f;/* jmp 0x1012ef1f */
        l_0x1012_ef19:
            ii(0x1012_ef19, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_ef1c, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1012_ef1f:
            ii(0x1012_ef1f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_ef22, 4);  cmp(ax, memw[ss, ebp - 20]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_ef26, 2);  if(jge(0x1012_ef99, 0x71)) goto l_0x1012_ef99;/* jge 0x1012ef99 */
            ii(0x1012_ef28, 5);  call(0x1013_19ac, 0x2a7f);            /* call 0x101319ac */
            ii(0x1012_ef2d, 1);  cwde();                               /* cwde */
            ii(0x1012_ef2e, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1012_ef31, 5);  mov(eax, 0xe);                        /* mov eax, 0xe */
            ii(0x1012_ef36, 5);  call(Definitions.sys_new, 0x3_6ec5);  /* call 0x10165e00 */
            ii(0x1012_ef3b, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x1012_ef3e, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1012_ef41, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1012_ef44, 4);  cmp(memd[ss, ebp - 108], 0);          /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1012_ef48, 2);  if(jz(0x1012_ef76, 0x2c)) goto l_0x1012_ef76;/* jz 0x1012ef76 */
            ii(0x1012_ef4a, 5);  mov(edx, StringDefinitions.Empty6);   /* mov edx, 0x101a87ed */
            ii(0x1012_ef4f, 3);  lea(eax, memd[ss, ebp - 112]);        /* lea eax, [ebp-0x70] */
            ii(0x1012_ef52, 5);  call(Definitions.my_string_ctor_char_ptr, 0x1_2ae4);/* call 0x10141a3b */
            ii(0x1012_ef57, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1012_ef59, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_ef5c, 5);  call(0x1013_1b38, 0x2bd7);            /* call 0x10131b38 */
            ii(0x1012_ef61, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_ef63, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1012_ef66, 5);  call(0x1013_1716, 0x27ab);            /* call 0x10131716 */
            ii(0x1012_ef6b, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1012_ef6e, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x1012_ef71, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x1012_ef74, 2);  jmp(0x1012_ef7c, 6); goto l_0x1012_ef7c;/* jmp 0x1012ef7c */
        l_0x1012_ef76:
            ii(0x1012_ef76, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1012_ef79, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
        l_0x1012_ef7c:
            ii(0x1012_ef7c, 3);  mov(edx, memd[ss, ebp - 120]);        /* mov edx, [ebp-0x78] */
            ii(0x1012_ef7f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_ef82, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_ef85, 3);  mov(ebx, memd[ss, ebp - 100]);        /* mov ebx, [ebp-0x64] */
            ii(0x1012_ef88, 5);  call(0x1013_18c0, 0x2933);            /* call 0x101318c0 */
            ii(0x1012_ef8d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_ef8f, 3);  lea(eax, memd[ss, ebp - 112]);        /* lea eax, [ebp-0x70] */
            ii(0x1012_ef92, 5);  call(Definitions.my_string_dtor, 0x1_2b93);/* call 0x10141b2a */
            ii(0x1012_ef97, 2);  jmp(0x1012_ef19, -0x80); goto l_0x1012_ef19;/* jmp 0x1012ef19 */
        l_0x1012_ef99:
            ii(0x1012_ef99, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x1012_ef9e, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1012_efa1, 5);  call(Definitions.sys_call_dtor_arr, 0x3_7012);/* call 0x10165fb8 */
            ii(0x1012_efa6, 5);  call(Definitions.sys_delete_arr, 0x3_702d);/* call 0x10165fd8 */
        l_0x1012_efab:
            ii(0x1012_efab, 5);  jmp(0x1012_ed17, -0x299); goto l_0x1012_ed17;/* jmp 0x1012ed17 */
        l_0x1012_efb0:
            ii(0x1012_efb0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efb3, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_efb6, 5);  call(Definitions.my_1_get_count, -0x8_3ae3);/* call 0x100ab4d8 */
            ii(0x1012_efbb, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1012_efbd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efc0, 4);  mov(bx, memw[ds, eax + 62]);          /* mov bx, [eax+0x3e] */
            ii(0x1012_efc4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efc7, 2);  sub(edx, ebx);                        /* sub edx, ebx */
            ii(0x1012_efc9, 4);  mov(memw[ds, eax + 52], dx);          /* mov [eax+0x34], dx */
            ii(0x1012_efcd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efd0, 3);  mov(eax, memd[ds, eax + 50]);         /* mov eax, [eax+0x32] */
            ii(0x1012_efd3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1012_efd6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1012_efd8, 2);  if(jge(0x1012_efe3, 9)) goto l_0x1012_efe3;/* jge 0x1012efe3 */
            ii(0x1012_efda, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efdd, 6);  mov(memw[ds, eax + 52], 0);           /* mov word [eax+0x34], 0x0 */
        l_0x1012_efe3:
            ii(0x1012_efe3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_efe5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_efe8, 3);  add(eax, 0x36);                       /* add eax, 0x36 */
            ii(0x1012_efeb, 5);  call(0x1013_1c3c, 0x2c4c);            /* call 0x10131c3c */
            ii(0x1012_eff0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1012_eff2, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1012_eff5, 5);  call(0x1011_7b8c, -0x1_746e);         /* call 0x10117b8c */
            ii(0x1012_effa, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_effc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_effd, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_effe, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_efff, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_f000, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_f001, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_f002, 1);  ret();                                /* ret */
        }
    }
}
