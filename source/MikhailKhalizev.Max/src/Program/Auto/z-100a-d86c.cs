using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d86c-1527bbb0")]
        public void Method_100a_d86c()
        {
            ii(0x100a_d86c, 5);  push(0x58);                           /* push 0x58 */
            ii(0x100a_d871, 5);  call(Definitions.sys_check_available_stack_size, 0xb_84dc);/* call 0x10165d52 */
            ii(0x100a_d876, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_d877, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_d878, 1);  push(esi);                            /* push esi */
            ii(0x100a_d879, 1);  push(edi);                            /* push edi */
            ii(0x100a_d87a, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_d87b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_d87d, 6);  sub(esp, 0x3c);                       /* sub esp, 0x3c */
            ii(0x100a_d883, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_d886, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_d889, 5);  mov(eax, 0x20);                       /* mov eax, 0x20 */
            ii(0x100a_d88e, 5);  call(Definitions.sys_new, 0xb_856d);  /* call 0x10165e00 */
            ii(0x100a_d893, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_d896, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_d899, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_d89c, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100a_d8a0, 2);  if(jz(0x100a_d8d4, 0x32)) goto l_0x100a_d8d4;/* jz 0x100ad8d4 */
            ii(0x100a_d8a2, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d8a5, 3);  add(edx, 0x22);                       /* add edx, 0x22 */
            ii(0x100a_d8a8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_d8ab, 5);  call(0x1007_5e64, -0x3_7a4c);         /* call 0x10075e64 */
            ii(0x100a_d8b0, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x100a_d8b2, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100a_d8b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d8b7, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_d8ba, 5);  call(0x1007_65d0, -0x3_72ef);         /* call 0x100765d0 */
            ii(0x100a_d8bf, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_d8c1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_d8c4, 5);  call(0x100a_beeb, -0x19de);           /* call 0x100abeeb */
            ii(0x100a_d8c9, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_d8cc, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_d8cf, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_d8d2, 2);  jmp(0x100a_d8da, 6); goto l_0x100a_d8da;/* jmp 0x100ad8da */
        l_0x100a_d8d4:
            ii(0x100a_d8d4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100a_d8d7, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x100a_d8da:
            ii(0x100a_d8da, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_d8dd, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x100a_d8e0, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x100a_d8e4, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_d8e7, 5);  call(Definitions.my_ctor_0x101b_3b58, -0x2_2848);/* call 0x1008b0a4 */
            ii(0x100a_d8ec, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100a_d8ef, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x100a_d8f3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d8f6, 3);  mov(edx, memd[ds, eax + 21]);         /* mov edx, [eax+0x15] */
            ii(0x100a_d8f9, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100a_d8fc, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_d8ff, 5);  call(0x1011_d85d, 0x6_ff59);          /* call 0x1011d85d */
            ii(0x100a_d904, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_d907, 3);  mov(edx, memd[ds, eax + 22]);         /* mov edx, [eax+0x16] */
            ii(0x100a_d90a, 3);  sar(edx, 0x18);                       /* sar edx, 0x18 */
            ii(0x100a_d90d, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_d910, 5);  call(0x1011_d801, 0x6_feec);          /* call 0x1011d801 */
            ii(0x100a_d915, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_d919, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100a_d91c, 5);  call(0x1011_d8e9, 0x6_ffc8);          /* call 0x1011d8e9 */
            ii(0x100a_d921, 5);  mov(eax, 0x1f);                       /* mov eax, 0x1f */
            ii(0x100a_d926, 5);  call(Definitions.sys_new, 0xb_84d5);  /* call 0x10165e00 */
            ii(0x100a_d92b, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100a_d92e, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_d931, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x100a_d934, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100a_d938, 2);  if(jz(0x100a_d95e, 0x24)) goto l_0x100a_d95e;/* jz 0x100ad95e */
            ii(0x100a_d93a, 5);  mov(eax, 0x100a_d995);                /* mov eax, 0x100ad995 */
            ii(0x100a_d93f, 1);  push(eax);                            /* push eax */
            ii(0x100a_d940, 5);  mov(ecx, 0x100a_d9cd);                /* mov ecx, 0x100ad9cd */
            ii(0x100a_d945, 3);  mov(ebx, memd[ss, ebp - 36]);         /* mov ebx, [ebp-0x24] */
            ii(0x100a_d948, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_d94b, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_d94e, 5);  call(0x100a_ba72, -0x1ee1);           /* call 0x100aba72 */
            ii(0x100a_d953, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x100a_d956, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_d959, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100a_d95c, 2);  jmp(0x100a_d964, 6); goto l_0x100a_d964;/* jmp 0x100ad964 */
        l_0x100a_d95e:
            ii(0x100a_d95e, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_d961, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
        l_0x100a_d964:
            ii(0x100a_d964, 3);  mov(edx, memd[ss, ebp - 60]);         /* mov edx, [ebp-0x3c] */
            ii(0x100a_d967, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_d96a, 5);  call(0x1008_afe4, -0x2_298b);         /* call 0x1008afe4 */
            ii(0x100a_d96f, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_d972, 5);  call(0x1008_af84, -0x2_29f3);         /* call 0x1008af84 */
            ii(0x100a_d977, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_d979, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100a_d97e, 5);  call(0x100a_4d50, -0x8c33);           /* call 0x100a4d50 */
            ii(0x100a_d983, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_d985, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x100a_d988, 5);  call(0x1008_8b7c, -0x2_4e11);         /* call 0x10088b7c */
            ii(0x100a_d98d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_d98f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_d990, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_d991, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_d992, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_d993, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_d994, 1);  ret();                                /* ret */
        }
    }
}
