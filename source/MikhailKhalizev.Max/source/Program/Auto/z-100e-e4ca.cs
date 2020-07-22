using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_e4ca-530447b3")]
        public void Method_100e_e4ca()
        {
            ii(0x100e_e4ca, 5);  push(0xbc);                           /* push 0xbc */
            ii(0x100e_e4cf, 5);  call(Definitions.sys_check_available_stack_size, 0x7_787e);/* call 0x10165d52 */
            ii(0x100e_e4d4, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_e4d5, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_e4d6, 1);  push(edx);                            /* push edx */
            ii(0x100e_e4d7, 1);  push(esi);                            /* push esi */
            ii(0x100e_e4d8, 1);  push(edi);                            /* push edi */
            ii(0x100e_e4d9, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_e4da, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_e4dc, 6);  sub(esp, 0x90);                       /* sub esp, 0x90 */
            ii(0x100e_e4e2, 7);  mov(memd[ss, ebp - 8], 9);            /* mov dword [ebp-0x8], 0x9 */
            ii(0x100e_e4e9, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_e4ed, 5);  call(/* sys */ 0x1016_5e9b, 0x7_79a9);/* call 0x10165e9b */
            ii(0x100e_e4f2, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100e_e4f5, 3);  shr(eax, 0xf);                        /* shr eax, 0xf */
            ii(0x100e_e4f8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_e4fb, 9);  mov(memw[ds, 0x101b_8674], 0xa);      /* mov word [0x101b8674], 0xa */
            ii(0x100e_e504, 5);  mov(edx, 0x101c_3f00);                /* mov edx, 0x101c3f00 */
            ii(0x100e_e509, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_e50c, 5);  call(Definitions.my_string_ctor_char_ptr, 0x5_352a);/* call 0x10141a3b */
            ii(0x100e_e511, 4);  or(memb[ss, ebp - 4], 1);             /* or byte [ebp-0x4], 0x1 */
            ii(0x100e_e515, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_e518, 5);  call(Definitions.my_string_ctor, 0x5_35cb);/* call 0x10141ae8 */
            ii(0x100e_e51d, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_e520, 4);  and(memb[ss, ebp - 4], -2 /* 0xfe */);/* and byte [ebp-0x4], 0xfe */
            ii(0x100e_e524, 4);  or(memb[ss, ebp - 4], 1);             /* or byte [ebp-0x4], 0x1 */
            ii(0x100e_e528, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e52b, 5);  call(Definitions.my_string_ctor, 0x5_35b8);/* call 0x10141ae8 */
            ii(0x100e_e530, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100e_e533, 4);  and(memb[ss, ebp - 4], -2 /* 0xfe */);/* and byte [ebp-0x4], 0xfe */
            ii(0x100e_e537, 5);  mov(eax, memd[ds, 0x101c_3980]);      /* mov eax, [0x101c3980] */
            ii(0x100e_e53c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_e53f, 1);  push(eax);                            /* push eax */
            ii(0x100e_e540, 5);  mov(eax, StringDefinitions.IntroICam);/* mov eax, 0x101a1fa2 */
            ii(0x100e_e545, 1);  push(eax);                            /* push eax */
            ii(0x100e_e546, 5);  mov(eax, 0x1e);                       /* mov eax, 0x1e */
            ii(0x100e_e54b, 1);  push(eax);                            /* push eax */
            ii(0x100e_e54c, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_e54f, 1);  push(eax);                            /* push eax */
            ii(0x100e_e550, 5);  call(0x1014_2037, 0x5_3ae2);          /* call 0x10142037 */
            ii(0x100e_e555, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x100e_e558, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100e_e55b, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_e55e, 5);  call(Definitions.my_string_append_string, 0x5_3726);/* call 0x10141c89 */
            ii(0x100e_e563, 5);  mov(edx, StringDefinitions.Rt5);      /* mov edx, 0x101a1fae */
            ii(0x100e_e568, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_e56b, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_4da8);/* call 0x100897c8 */
            ii(0x100e_e570, 5);  call(Definitions.my_fopen, 0xeaa);    /* call 0x100ef41f */
            ii(0x100e_e575, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_e578, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100e_e57c, 2);  if(jnz(0x100e_e5a1, 0x23)) goto l_0x100e_e5a1;/* jnz 0x100ee5a1 */
            ii(0x100e_e57e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e580, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e583, 5);  call(Definitions.my_string_dtor, 0x5_35a2);/* call 0x10141b2a */
            ii(0x100e_e588, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e58a, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_e58d, 5);  call(Definitions.my_string_dtor, 0x5_3598);/* call 0x10141b2a */
            ii(0x100e_e592, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e594, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_e597, 5);  call(Definitions.my_string_dtor, 0x5_358e);/* call 0x10141b2a */
            ii(0x100e_e59c, 5);  jmp(0x100e_e878, 0x2d7); goto l_0x100e_e878;/* jmp 0x100ee878 */
        l_0x100e_e5a1:
            ii(0x100e_e5a1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_e5a4, 5);  call(/* sys */ 0x1017_1f05, 0x8_395c);/* call 0x10171f05 */
            ii(0x100e_e5a9, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_e5ac, 4);  cmp(memd[ss, ebp - 12], -1 /* 0xff */);/* cmp dword [ebp-0xc], 0xffffffff */
            ii(0x100e_e5b0, 2);  if(jz(0x100e_e5c1, 0xf)) goto l_0x100e_e5c1;/* jz 0x100ee5c1 */
            ii(0x100e_e5b2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e5b4, 3);  mov(dl, memb[ss, ebp - 12]);          /* mov dl, [ebp-0xc] */
            ii(0x100e_e5b7, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e5ba, 5);  call(Definitions.my_string_append_char, 0x5_382b);/* call 0x10141dea */
            ii(0x100e_e5bf, 2);  jmp(0x100e_e5a1, -0x20); goto l_0x100e_e5a1;/* jmp 0x100ee5a1 */
        l_0x100e_e5c1:
            ii(0x100e_e5c1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_e5c4, 5);  call(Definitions.sys_fclose, 0x8_3aa0);/* call 0x10172069 */
            ii(0x100e_e5c9, 4);  or(memb[ss, ebp - 4], 1);             /* or byte [ebp-0x4], 0x1 */
            ii(0x100e_e5cd, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_e5d1, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100e_e5d3, 6);  mov(edx, memd[ds, edx + 0x101b_8676]);/* mov edx, [edx+0x101b8676] */
            ii(0x100e_e5d9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100e_e5dc, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e5df, 5);  call(0x100d_67d8, -0x1_7e0c);         /* call 0x100d67d8 */
            ii(0x100e_e5e4, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x100e_e5e7, 4);  and(memb[ss, ebp - 4], -2 /* 0xfe */);/* and byte [ebp-0x4], 0xfe */
            ii(0x100e_e5eb, 5);  mov(edx, 0x10);                       /* mov edx, 0x10 */
            ii(0x100e_e5f0, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e5f3, 5);  call(0x100e_f318, 0xd20);             /* call 0x100ef318 */
            ii(0x100e_e5f8, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_e5fd, 5);  call(0x1012_0d94, 0x3_2792);          /* call 0x10120d94 */
            ii(0x100e_e602, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_e607, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e60a, 5);  call(0x100e_f2e8, 0xcd9);             /* call 0x100ef2e8 */
            ii(0x100e_e60f, 5);  call(0x100d_6124, -0x1_84f0);         /* call 0x100d6124 */
            ii(0x100e_e614, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e616, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100e_e618, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e61b, 5);  call(0x100d_6adf, -0x1_7b41);         /* call 0x100d6adf */
            ii(0x100e_e620, 3);  lea(edx, memd[ss, ebp - 92]);         /* lea edx, [ebp-0x5c] */
            ii(0x100e_e623, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e626, 5);  call(0x100d_6a11, -0x1_7c1a);         /* call 0x100d6a11 */
            ii(0x100e_e62b, 3);  mov(eax, memd[ss, ebp - 74]);         /* mov eax, [ebp-0x4a] */
            ii(0x100e_e62e, 5);  call(Definitions.sys_display_draw_0, 0x7_8e51);/* call 0x10167484 */
            ii(0x100e_e633, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_e638, 5);  call(/* sys */ 0x1016_a24c, 0x7_bc0f);/* call 0x1016a24c */
            ii(0x100e_e63d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_e63f, 1);  push(eax);                            /* push eax */
            ii(0x100e_e640, 5);  mov(eax, 0x190);                      /* mov eax, 0x190 */
            ii(0x100e_e645, 1);  push(eax);                            /* push eax */
            ii(0x100e_e646, 5);  mov(eax, 0x258);                      /* mov eax, 0x258 */
            ii(0x100e_e64b, 1);  push(eax);                            /* push eax */
            ii(0x100e_e64c, 5);  mov(ecx, 0x14);                       /* mov ecx, 0x14 */
            ii(0x100e_e651, 5);  mov(ebx, 0x14);                       /* mov ebx, 0x14 */
            ii(0x100e_e656, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e659, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_4e96);/* call 0x100897c8 */
            ii(0x100e_e65e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_e660, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x100e_e663, 5);  call(0x100e_d950, -0xd18);            /* call 0x100ed950 */
            ii(0x100e_e668, 9);  mov(memw[ds, 0x101b_8674], 0);        /* mov word [0x101b8674], 0x0 */
            ii(0x100e_e671, 5);  mov(eax, 5);                          /* mov eax, 0x5 */
            ii(0x100e_e676, 5);  call(/* sys */ 0x1016_a24c, 0x7_bbd1);/* call 0x1016a24c */
            ii(0x100e_e67b, 5);  mov(eax, 0x38);                       /* mov eax, 0x38 */
            ii(0x100e_e680, 5);  call(Definitions.sys_new, 0x7_777b);  /* call 0x10165e00 */
            ii(0x100e_e685, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100e_e688, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100e_e68b, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100e_e68e, 4);  cmp(memd[ss, ebp - 100], 0);          /* cmp dword [ebp-0x64], 0x0 */
            ii(0x100e_e692, 2);  if(jz(0x100e_e6bc, 0x28)) goto l_0x100e_e6bc;/* jz 0x100ee6bc */
            ii(0x100e_e694, 5);  mov(eax, 0x1ca);                      /* mov eax, 0x1ca */
            ii(0x100e_e699, 1);  push(eax);                            /* push eax */
            ii(0x100e_e69a, 5);  mov(ecx, 0x125);                      /* mov ecx, 0x125 */
            ii(0x100e_e69f, 5);  mov(ebx, 0x15b);                      /* mov ebx, 0x15b */
            ii(0x100e_e6a4, 5);  mov(edx, 0x15a);                      /* mov edx, 0x15a */
            ii(0x100e_e6a9, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100e_e6ac, 5);  call(Definitions.my_ctor_c17, -0x2_02a2);/* call 0x100ce40f */
            ii(0x100e_e6b1, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100e_e6b4, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x100e_e6b7, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x100e_e6ba, 2);  jmp(0x100e_e6c2, 6); goto l_0x100e_e6c2;/* jmp 0x100ee6c2 */
        l_0x100e_e6bc:
            ii(0x100e_e6bc, 3);  mov(eax, memd[ss, ebp - 100]);        /* mov eax, [ebp-0x64] */
            ii(0x100e_e6bf, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
        l_0x100e_e6c2:
            ii(0x100e_e6c2, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x100e_e6c5, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x100e_e6c8, 3);  lea(eax, memd[ss, ebp - 116]);        /* lea eax, [ebp-0x74] */
            ii(0x100e_e6cb, 5);  call(0x100d_5224, -0x1_94ac);         /* call 0x100d5224 */
            ii(0x100e_e6d0, 1);  push(eax);                            /* push eax */
            ii(0x100e_e6d1, 3);  lea(eax, memd[ss, ebp - 120]);        /* lea eax, [ebp-0x78] */
            ii(0x100e_e6d4, 5);  call(0x100d_5250, -0x1_9489);         /* call 0x100d5250 */
            ii(0x100e_e6d9, 1);  push(eax);                            /* push eax */
            ii(0x100e_e6da, 3);  lea(eax, memd[ss, ebp - 124]);        /* lea eax, [ebp-0x7c] */
            ii(0x100e_e6dd, 5);  call(0x100d_527c, -0x1_9466);         /* call 0x100d527c */
            ii(0x100e_e6e2, 1);  push(eax);                            /* push eax */
            ii(0x100e_e6e3, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x100e_e6e6, 5);  call(0x100d_52a8, -0x1_9443);         /* call 0x100d52a8 */
            ii(0x100e_e6eb, 1);  push(eax);                            /* push eax */
            ii(0x100e_e6ec, 5);  call(0x100d_52d4, -0x1_941d);         /* call 0x100d52d4 */
            ii(0x100e_e6f1, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x100e_e6f4, 5);  call(0x100d_52f8, -0x1_9401);         /* call 0x100d52f8 */
            ii(0x100e_e6f9, 3);  movsx(ebx, ax);                       /* movsx ebx, ax */
            ii(0x100e_e6fc, 5);  mov(edx, StringDefinitions.Ok3);      /* mov edx, 0x101a1fb1 */
            ii(0x100e_e701, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x100e_e704, 5);  call(0x100c_ef64, -0x1_f7a5);         /* call 0x100cef64 */
            ii(0x100e_e709, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_e70e, 5);  call(/* sys */ 0x1016_a24c, 0x7_bb39);/* call 0x1016a24c */
            ii(0x100e_e713, 5);  mov(edx, 0x1b);                       /* mov edx, 0x1b */
            ii(0x100e_e718, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x100e_e71b, 5);  call(0x100d_5134, -0x1_95ec);         /* call 0x100d5134 */
            ii(0x100e_e720, 3);  mov(edx, memd[ss, ebp - 74]);         /* mov edx, [ebp-0x4a] */
            ii(0x100e_e723, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x100e_e726, 5);  call(0x100c_f85c, -0x1_eecf);         /* call 0x100cf85c */
            ii(0x100e_e72b, 3);  mov(eax, memd[ss, ebp - 74]);         /* mov eax, [ebp-0x4a] */
            ii(0x100e_e72e, 5);  call(Definitions.sys_display_draw_0, 0x7_8d51);/* call 0x10167484 */
            ii(0x100e_e733, 7);  mov(memb[ss, ebp - 132], 0);          /* mov byte [ebp-0x84], 0x0 */
        l_0x100e_e73a:
            ii(0x100e_e73a, 5);  call(/* sys */ 0x1016_b208, 0x7_cac9);/* call 0x1016b208 */
            ii(0x100e_e73f, 6);  mov(memd[ss, ebp - 136], eax);        /* mov [ebp-0x88], eax */
            ii(0x100e_e745, 5);  jmp(0x100e_e7d9, 0x8f); goto l_0x100e_e7d9;/* jmp 0x100ee7d9 */
        l_0x100e_e74a:
            ii(0x100e_e74a, 7);  mov(memb[ss, ebp - 132], 1);          /* mov byte [ebp-0x84], 0x1 */
            ii(0x100e_e751, 5);  jmp(0x100e_e80d, 0xb7); goto l_0x100e_e80d;/* jmp 0x100ee80d */
        l_0x100e_e756:
            ii(0x100e_e756, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_e75a, 1);  inc(eax);                             /* inc eax */
            ii(0x100e_e75b, 5);  mov(ebx, 9);                          /* mov ebx, 0x9 */
            ii(0x100e_e760, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e762, 2);  div(ebx);                             /* div ebx */
            ii(0x100e_e764, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_e767, 5);  call(0x100d_533c, -0x1_9430);         /* call 0x100d533c */
            ii(0x100e_e76c, 1);  cwde();                               /* cwde */
            ii(0x100e_e76d, 1);  push(eax);                            /* push eax */
            ii(0x100e_e76e, 5);  call(0x100d_5360, -0x1_9413);         /* call 0x100d5360 */
            ii(0x100e_e773, 1);  cwde();                               /* cwde */
            ii(0x100e_e774, 1);  push(eax);                            /* push eax */
            ii(0x100e_e775, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_e777, 1);  push(eax);                            /* push eax */
            ii(0x100e_e778, 5);  mov(ecx, 1);                          /* mov ecx, 0x1 */
            ii(0x100e_e77d, 4);  movsx(ebx, memw[ss, ebp - 76]);       /* movsx ebx, word [ebp-0x4c] */
            ii(0x100e_e781, 3);  lea(edx, memd[ss, ebp - 92]);         /* lea edx, [ebp-0x5c] */
            ii(0x100e_e784, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_e788, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100e_e78a, 6);  mov(eax, memd[ds, eax + 0x101b_8676]);/* mov eax, [eax+0x101b8676] */
            ii(0x100e_e790, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100e_e793, 5);  call(0x100e_8c51, -0x5b47);           /* call 0x100e8c51 */
            ii(0x100e_e798, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x100e_e79d, 5);  call(/* sys */ 0x1016_a24c, 0x7_baaa);/* call 0x1016a24c */
            ii(0x100e_e7a2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_e7a4, 1);  push(eax);                            /* push eax */
            ii(0x100e_e7a5, 5);  mov(eax, 0x190);                      /* mov eax, 0x190 */
            ii(0x100e_e7aa, 1);  push(eax);                            /* push eax */
            ii(0x100e_e7ab, 5);  mov(eax, 0x258);                      /* mov eax, 0x258 */
            ii(0x100e_e7b0, 1);  push(eax);                            /* push eax */
            ii(0x100e_e7b1, 5);  mov(ecx, 0x14);                       /* mov ecx, 0x14 */
            ii(0x100e_e7b6, 5);  mov(ebx, 0x14);                       /* mov ebx, 0x14 */
            ii(0x100e_e7bb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e7be, 5);  call(Definitions.my_strobj_c_str_v2, -0x6_4ffb);/* call 0x100897c8 */
            ii(0x100e_e7c3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100e_e7c5, 3);  lea(eax, memd[ss, ebp - 92]);         /* lea eax, [ebp-0x5c] */
            ii(0x100e_e7c8, 5);  call(0x100e_d950, -0xe7d);            /* call 0x100ed950 */
            ii(0x100e_e7cd, 3);  mov(eax, memd[ss, ebp - 74]);         /* mov eax, [ebp-0x4a] */
            ii(0x100e_e7d0, 5);  call(Definitions.sys_display_draw_0, 0x7_8caf);/* call 0x10167484 */
            ii(0x100e_e7d5, 2);  jmp(0x100e_e80d, 0x36); goto l_0x100e_e80d;/* jmp 0x100ee80d */
        l_0x100e_e7d7:
            ii(0x100e_e7d7, 2);  jmp(0x100e_e80d, 0x34); goto l_0x100e_e80d;/* jmp 0x100ee80d */
        l_0x100e_e7d9:
            ii(0x100e_e7d9, 7);  cmp(memd[ss, ebp - 136], 0x1b);       /* cmp dword [ebp-0x88], 0x1b */
            ii(0x100e_e7e0, 2);  if(jb(0x100e_e7fe, 0x1c)) goto l_0x100e_e7fe;/* jb 0x100ee7fe */
            ii(0x100e_e7e2, 7);  cmp(memd[ss, ebp - 136], 0x1b);       /* cmp dword [ebp-0x88], 0x1b */
            ii(0x100e_e7e9, 6);  if(jbe(0x100e_e74a, -0xa5)) goto l_0x100e_e74a;/* jbe 0x100ee74a */
            ii(0x100e_e7ef, 7);  cmp(memd[ss, ebp - 136], 0x20);       /* cmp dword [ebp-0x88], 0x20 */
            ii(0x100e_e7f6, 6);  if(jz(0x100e_e756, -0xa6)) goto l_0x100e_e756;/* jz 0x100ee756 */
            ii(0x100e_e7fc, 2);  jmp(0x100e_e7d7, -0x27); goto l_0x100e_e7d7;/* jmp 0x100ee7d7 */
        l_0x100e_e7fe:
            ii(0x100e_e7fe, 7);  cmp(memd[ss, ebp - 136], 0xd);        /* cmp dword [ebp-0x88], 0xd */
            ii(0x100e_e805, 6);  if(jz(0x100e_e74a, -0xc1)) goto l_0x100e_e74a;/* jz 0x100ee74a */
            ii(0x100e_e80b, 2);  jmp(0x100e_e7d7, -0x36); goto l_0x100e_e7d7;/* jmp 0x100ee7d7 */
        l_0x100e_e80d:
            ii(0x100e_e80d, 7);  cmp(memb[ss, ebp - 132], 0);          /* cmp byte [ebp-0x84], 0x0 */
            ii(0x100e_e814, 6);  if(jz(0x100e_e73a, -0xe0)) goto l_0x100e_e73a;/* jz 0x100ee73a */
            ii(0x100e_e81a, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x100e_e81d, 6);  mov(memd[ss, ebp - 140], eax);        /* mov [ebp-0x8c], eax */
            ii(0x100e_e823, 7);  cmp(memd[ss, ebp - 140], 0);          /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x100e_e82a, 2);  if(jz(0x100e_e846, 0x1a)) goto l_0x100e_e846;/* jz 0x100ee846 */
            ii(0x100e_e82c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e82e, 6);  mov(eax, memd[ss, ebp - 140]);        /* mov eax, [ebp-0x8c] */
            ii(0x100e_e834, 5);  call(Definitions.my_dtor_d2, -0x2_0301);/* call 0x100ce538 */
            ii(0x100e_e839, 5);  call(Definitions.sys_delete, 0x7_7726);/* call 0x10165f64 */
            ii(0x100e_e83e, 6);  mov(memd[ss, ebp - 144], eax);        /* mov [ebp-0x90], eax */
            ii(0x100e_e844, 2);  jmp(0x100e_e850, 0xa); goto l_0x100e_e850;/* jmp 0x100ee850 */
        l_0x100e_e846:
            ii(0x100e_e846, 10);  mov(memd[ss, ebp - 144], 0);         /* mov dword [ebp-0x90], 0x0 */
        l_0x100e_e850:
            ii(0x100e_e850, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e852, 3);  lea(eax, memd[ss, ebp - 60]);         /* lea eax, [ebp-0x3c] */
            ii(0x100e_e855, 5);  call(0x100d_6999, -0x1_7ec1);         /* call 0x100d6999 */
            ii(0x100e_e85a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e85c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100e_e85f, 5);  call(Definitions.my_string_dtor, 0x5_32c6);/* call 0x10141b2a */
            ii(0x100e_e864, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e866, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_e869, 5);  call(Definitions.my_string_dtor, 0x5_32bc);/* call 0x10141b2a */
            ii(0x100e_e86e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_e870, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x100e_e873, 5);  call(Definitions.my_string_dtor, 0x5_32b2);/* call 0x10141b2a */
        l_0x100e_e878:
            ii(0x100e_e878, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_e87a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_e87b, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_e87c, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_e87d, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_e87e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_e87f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_e880, 1);  ret();                                /* ret */
        }
    }
}
