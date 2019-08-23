using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_cfd2-4b36a0ef")]
        public void Method_1010_cfd2()
        {
            ii(0x1010_cfd2, 5); push(0x7c);                             /* push 0x7c */
            ii(0x1010_cfd7, 5); call(Definitions.sys_check_available_stack_size, 0x5_8d76); /* call 0x10165d52 */
            ii(0x1010_cfdc, 1); push(esi);                              /* push esi */
            ii(0x1010_cfdd, 1); push(edi);                              /* push edi */
            ii(0x1010_cfde, 1); push(ebp);                              /* push ebp */
            ii(0x1010_cfdf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_cfe1, 6); sub(esp, 0x54);                         /* sub esp, 0x54 */
            ii(0x1010_cfe7, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_cfea, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1010_cfed, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_cff0, 3); mov(memb[ss, ebp - 0x4], cl);           /* mov [ebp-0x4], cl */
            ii(0x1010_cff3, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1010_cff7, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_cffc, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_cffe, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d001, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_d003, 5); add(eax, 0x768);                        /* add eax, 0x768 */
            ii(0x1010_d008, 1); cwde();                                 /* cwde */
            ii(0x1010_d009, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x2_71dd); /* call 0x101341eb */
            ii(0x1010_d00e, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_d011, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x1010_d015, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1010_d01a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_d01c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d01f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_d021, 5); add(eax, 0x768);                        /* add eax, 0x768 */
            ii(0x1010_d026, 1); cwde();                                 /* cwde */
            ii(0x1010_d027, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x2_71bf); /* call 0x101341eb */
            ii(0x1010_d02c, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_d02f, 5); mov(eax, 0x76c);                        /* mov eax, 0x76c */
            ii(0x1010_d034, 5); call(Definitions.my_get_res_data_by_id_malloc, 0x2_71b2); /* call 0x101341eb */
            ii(0x1010_d039, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_d03c, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_d040, 2); if(jz(0x1010_d048, 0x6)) goto l_0x1010_d048; /* jz 0x1010d048 */
            ii(0x1010_d042, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1010_d046, 2); if(jnz(0x1010_d04a, 0x2)) goto l_0x1010_d04a; /* jnz 0x1010d04a */
        l_0x1010_d048:
            ii(0x1010_d048, 2); jmp(0x1010_d050, 0x6); goto l_0x1010_d050; /* jmp 0x1010d050 */
        l_0x1010_d04a:
            ii(0x1010_d04a, 4); cmp(memd[ss, ebp - 0x1c], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_d04e, 2); if(jnz(0x1010_d055, 0x5)) goto l_0x1010_d055; /* jnz 0x1010d055 */
        l_0x1010_d050:
            ii(0x1010_d050, 5); jmp(0x1010_d254, 0x1ff); goto l_0x1010_d254; /* jmp 0x1010d254 */
        l_0x1010_d055:
            ii(0x1010_d055, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_d058, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_d05b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_d05e, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_d061, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_d064, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_d067, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d06a, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x1010_d06e, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_d071, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d074, 4); mov(ax, memw[ds, eax + 0x6]);           /* mov ax, [eax+0x6] */
            ii(0x1010_d078, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_d07b, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1010_d07f, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_d083, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x1010_d086, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x1010_d089, 5); call(Definitions.sys_new_arr, 0x5_8f82); /* call 0x10166010 */
            ii(0x1010_d08e, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_d091, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_d095, 2); if(jz(0x1010_d0e4, 0x4d)) goto l_0x1010_d0e4; /* jz 0x1010d0e4 */
            ii(0x1010_d097, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d09b, 1); cwde();                                 /* cwde */
            ii(0x1010_d09c, 1); push(eax);                              /* push eax */
            ii(0x1010_d09d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d09f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d0a1, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1010_d0a4, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d0a7, 5); call(0x100e_8b24, -0x2_4588);           /* call 0x100e8b24 */
            ii(0x1010_d0ac, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d0b0, 1); cwde();                                 /* cwde */
            ii(0x1010_d0b1, 1); push(eax);                              /* push eax */
            ii(0x1010_d0b2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d0b4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d0b6, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1010_d0ba, 3); add(edx, memd[ss, ebp - 0x34]);         /* add edx, [ebp-0x34] */
            ii(0x1010_d0bd, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_d0c0, 5); call(0x100e_8b24, -0x2_45a1);           /* call 0x100e8b24 */
            ii(0x1010_d0c5, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d0c9, 1); cwde();                                 /* cwde */
            ii(0x1010_d0ca, 1); push(eax);                              /* push eax */
            ii(0x1010_d0cb, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d0cd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d0cf, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1010_d0d3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1010_d0d5, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1010_d0d8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d0da, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_d0dd, 5); call(0x100e_8b24, -0x2_45be);           /* call 0x100e8b24 */
            ii(0x1010_d0e2, 2); jmp(0x1010_d12d, 0x49); goto l_0x1010_d12d; /* jmp 0x1010d12d */
        l_0x1010_d0e4:
            ii(0x1010_d0e4, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d0e8, 1); cwde();                                 /* cwde */
            ii(0x1010_d0e9, 1); push(eax);                              /* push eax */
            ii(0x1010_d0ea, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d0ec, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d0ee, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1010_d0f2, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1010_d0f4, 3); add(edx, memd[ss, ebp - 0x34]);         /* add edx, [ebp-0x34] */
            ii(0x1010_d0f7, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d0fa, 5); call(0x100e_8b24, -0x2_45db);           /* call 0x100e8b24 */
            ii(0x1010_d0ff, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d103, 1); cwde();                                 /* cwde */
            ii(0x1010_d104, 1); push(eax);                              /* push eax */
            ii(0x1010_d105, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d107, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d109, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1010_d10d, 3); add(edx, memd[ss, ebp - 0x34]);         /* add edx, [ebp-0x34] */
            ii(0x1010_d110, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_d113, 5); call(0x100e_8b24, -0x2_45f4);           /* call 0x100e8b24 */
            ii(0x1010_d118, 4); imul(eax, memd[ss, ebp - 0x2c], 0x3);   /* imul eax, [ebp-0x2c], 0x3 */
            ii(0x1010_d11c, 1); cwde();                                 /* cwde */
            ii(0x1010_d11d, 1); push(eax);                              /* push eax */
            ii(0x1010_d11e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_d120, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_d122, 3); mov(edx, memd[ss, ebp - 0x34]);         /* mov edx, [ebp-0x34] */
            ii(0x1010_d125, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_d128, 5); call(0x100e_8b24, -0x2_4609);           /* call 0x100e8b24 */
        l_0x1010_d12d:
            ii(0x1010_d12d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d130, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1010_d133, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1010_d136, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_d139, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d13b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d13e, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1010_d141, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1010_d145, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x1010_d148, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d14a, 3); mov(memd[ss, ebp - 0x3c], edx);         /* mov [ebp-0x3c], edx */
            ii(0x1010_d14d, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_d151, 3); mov(edx, memd[ss, ebp - 0x40]);         /* mov edx, [ebp-0x40] */
            ii(0x1010_d154, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d156, 3); mov(memd[ss, ebp - 0x38], edx);         /* mov [ebp-0x38], edx */
            ii(0x1010_d159, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_d15c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d15e, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1010_d161, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d164, 3); mov(edx, memd[ss, ebp - 0x40]);         /* mov edx, [ebp-0x40] */
            ii(0x1010_d167, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_d16a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_d16d, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d16f, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1010_d172, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_d174, 3); mov(edx, memd[ss, ebp - 0x44]);         /* mov edx, [ebp-0x44] */
            ii(0x1010_d177, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d179, 3); mov(memd[ss, ebp - 0x48], edx);         /* mov [ebp-0x48], edx */
            ii(0x1010_d17c, 7); mov(memd[ss, ebp - 0x4c], 0x1);         /* mov dword [ebp-0x4c], 0x1 */
            ii(0x1010_d183, 2); jmp(0x1010_d18b, 0x6); goto l_0x1010_d18b; /* jmp 0x1010d18b */
        l_0x1010_d185:
            ii(0x1010_d185, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1010_d188, 3); inc(memd[ss, ebp - 0x4c]);              /* inc dword [ebp-0x4c] */
        l_0x1010_d18b:
            ii(0x1010_d18b, 4); movsx(eax, memw[ss, ebp - 0x4c]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x1010_d18f, 3); cmp(eax, 0x10);                         /* cmp eax, 0x10 */
            ii(0x1010_d192, 6); if(jg(0x1010_d234, 0x9c)) goto l_0x1010_d234; /* jg 0x1010d234 */
            ii(0x1010_d198, 5); call(0x1014_82f4, 0x3_b157);            /* call 0x101482f4 */
            ii(0x1010_d19d, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x1010_d1a0, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1010_d1a4, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1010_d1a6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_d1a8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_d1ab, 3); shl(edx, 0x4);                          /* shl edx, 0x4 */
            ii(0x1010_d1ae, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x1010_d1b0, 3); sar(eax, 0x4);                          /* sar eax, 0x4 */
            ii(0x1010_d1b3, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1010_d1b6, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_d1ba, 2); if(jz(0x1010_d1c8, 0xc)) goto l_0x1010_d1c8; /* jz 0x1010d1c8 */
            ii(0x1010_d1bc, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1010_d1bf, 4); imul(eax, memd[ss, ebp - 0x54]);        /* imul eax, [ebp-0x54] */
            ii(0x1010_d1c3, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x1010_d1c6, 2); jmp(0x1010_d1d9, 0x11); goto l_0x1010_d1d9; /* jmp 0x1010d1d9 */
        l_0x1010_d1c8:
            ii(0x1010_d1c8, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1010_d1cd, 3); sub(eax, memd[ss, ebp - 0x4c]);         /* sub eax, [ebp-0x4c] */
            ii(0x1010_d1d0, 3); mov(edx, memd[ss, ebp - 0x54]);         /* mov edx, [ebp-0x54] */
            ii(0x1010_d1d3, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1010_d1d6, 3); mov(memd[ss, ebp - 0x54], edx);         /* mov [ebp-0x54], edx */
        l_0x1010_d1d9:
            ii(0x1010_d1d9, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_d1dc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d1de, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1010_d1e1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d1e4, 1); push(eax);                              /* push eax */
            ii(0x1010_d1e5, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x1010_d1e8, 1); push(eax);                              /* push eax */
            ii(0x1010_d1e9, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1010_d1ed, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x1010_d1f0, 1); push(eax);                              /* push eax */
            ii(0x1010_d1f1, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1010_d1f5, 1); push(eax);                              /* push eax */
            ii(0x1010_d1f6, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1010_d1fa, 1); push(eax);                              /* push eax */
            ii(0x1010_d1fb, 4); movsx(eax, memw[ss, ebp - 0x54]);       /* movsx eax, word [ebp-0x54] */
            ii(0x1010_d1ff, 3); add(eax, memd[ss, ebp - 0x34]);         /* add eax, [ebp-0x34] */
            ii(0x1010_d202, 1); push(eax);                              /* push eax */
            ii(0x1010_d203, 5); call(/* sys */ 0x1016_abbc, 0x5_d9b4);  /* call 0x1016abbc */
            ii(0x1010_d208, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1010_d20b, 3); lea(edx, memd[ss, ebp - 0x44]);         /* lea edx, [ebp-0x44] */
            ii(0x1010_d20e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_d211, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d213, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_d216, 5); call(Definitions.sys_display_draw_1, 0x5_a28d); /* call 0x101674a8 */
            ii(0x1010_d21b, 5); call(/* sys */ 0x1016_b258, 0x5_e038);  /* call 0x1016b258 */
        l_0x1010_d220:
            ii(0x1010_d220, 5); call(0x1014_82f4, 0x3_b0cf);            /* call 0x101482f4 */
            ii(0x1010_d225, 3); sub(eax, memd[ss, ebp - 0x50]);         /* sub eax, [ebp-0x50] */
            ii(0x1010_d228, 5); cmp(eax, 0xc233);                       /* cmp eax, 0xc233 */
            ii(0x1010_d22d, 2); if(jb(0x1010_d220, -0xf)) goto l_0x1010_d220; /* jb 0x1010d220 */
            ii(0x1010_d22f, 5); jmp(0x1010_d185, -0xaf); goto l_0x1010_d185; /* jmp 0x1010d185 */
        l_0x1010_d234:
            ii(0x1010_d234, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_d237, 5); call(Definitions.sys_delete, 0x5_8d28); /* call 0x10165f64 */
            ii(0x1010_d23c, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_d23f, 5); call(Definitions.sys_delete, 0x5_8d20); /* call 0x10165f64 */
            ii(0x1010_d244, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_d247, 5); call(Definitions.sys_delete, 0x5_8d18); /* call 0x10165f64 */
            ii(0x1010_d24c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_d24f, 5); call(Definitions.sys_delete, 0x5_8d10); /* call 0x10165f64 */
        l_0x1010_d254:
            ii(0x1010_d254, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d256, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_d257, 1); pop(edi);                               /* pop edi */
            ii(0x1010_d258, 1); pop(esi);                               /* pop esi */
            ii(0x1010_d259, 1); ret();                                  /* ret */
        }
    }
}
