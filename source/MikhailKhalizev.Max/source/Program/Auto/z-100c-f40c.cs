using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f40c-3e2cd08")]
        public void Method_100c_f40c()
        {
            ii(0x100c_f40c, 5);  push(0x50);                           /* push 0x50 */
            ii(0x100c_f411, 5);  call(Definitions.sys_check_available_stack_size, 0x9_693c);/* call 0x10165d52 */
            ii(0x100c_f416, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_f417, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_f418, 1);  push(esi);                            /* push esi */
            ii(0x100c_f419, 1);  push(edi);                            /* push edi */
            ii(0x100c_f41a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_f41b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_f41d, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100c_f423, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_f426, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_f429, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f42c, 4);  cmp(memd[ds, eax + 12], 0);           /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_f430, 2);  if(jz(0x100c_f45c, 0x2a)) goto l_0x100c_f45c;/* jz 0x100cf45c */
            ii(0x100c_f432, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f435, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100c_f438, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f43b, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_f43f, 2);  if(jz(0x100c_f455, 0x14)) goto l_0x100c_f455;/* jz 0x100cf455 */
            ii(0x100c_f441, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_f443, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f446, 5);  call(Definitions.my_dtor_d3, 0x88e8); /* call 0x100d7d33 */
            ii(0x100c_f44b, 5);  call(Definitions.sys_delete, 0x9_6b14);/* call 0x10165f64 */
            ii(0x100c_f450, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f453, 2);  jmp(0x100c_f45c, 7); goto l_0x100c_f45c;/* jmp 0x100cf45c */
        l_0x100c_f455:
            ii(0x100c_f455, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100c_f45c:
            ii(0x100c_f45c, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100c_f461, 5);  call(Definitions.sys_new, 0x9_699a);  /* call 0x10165e00 */
            ii(0x100c_f466, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_f469, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_f46c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f46f, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_f473, 2);  if(jz(0x100c_f4ad, 0x38)) goto l_0x100c_f4ad;/* jz 0x100cf4ad */
            ii(0x100c_f475, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f478, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f47b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f47e, 1);  push(eax);                            /* push eax */
            ii(0x100c_f47f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f482, 3);  mov(ecx, memd[ds, eax + 6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f485, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_f488, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f48b, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f48e, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_f491, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f494, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f497, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_f49a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_f49d, 5);  call(0x100d_7bdc, 0x873a);            /* call 0x100d7bdc */
            ii(0x100c_f4a2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f4a5, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f4a8, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_f4ab, 2);  jmp(0x100c_f4b3, 6); goto l_0x100c_f4b3;/* jmp 0x100cf4b3 */
        l_0x100c_f4ad:
            ii(0x100c_f4ad, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_f4b0, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_f4b3:
            ii(0x100c_f4b3, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_f4b6, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f4b9, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x100c_f4bc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f4bf, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f4c2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f4c5, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f4c9, 3);  mov(eax, memd[ds, eax + 12]);         /* mov eax, [eax+0xc] */
            ii(0x100c_f4cc, 5);  call(0x100d_4e8c, 0x59bb);            /* call 0x100d4e8c */
            ii(0x100c_f4d1, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4d2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f4d5, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f4d8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f4db, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4dc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f4df, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f4e2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f4e5, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4e6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f4e9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f4ec, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f4ef, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4f0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f4f3, 1);  push(eax);                            /* push eax */
            ii(0x100c_f4f4, 5);  call(/* sys */ 0x1016_abbc, 0x9_b6c3);/* call 0x1016abbc */
            ii(0x100c_f4f9, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100c_f4fc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_f4fe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_f4ff, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_f500, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_f501, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_f502, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_f503, 1);  ret();                                /* ret */
        }
    }
}
