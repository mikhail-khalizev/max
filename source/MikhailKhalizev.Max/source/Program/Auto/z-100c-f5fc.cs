using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f5fc-7940033a")]
        public void Method_100c_f5fc()
        {
            ii(0x100c_f5fc, 5);  push(0x50);                           /* push 0x50 */
            ii(0x100c_f601, 5);  call(Definitions.sys_check_available_stack_size, 0x9_674c);/* call 0x10165d52 */
            ii(0x100c_f606, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_f607, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_f608, 1);  push(esi);                            /* push esi */
            ii(0x100c_f609, 1);  push(edi);                            /* push edi */
            ii(0x100c_f60a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_f60b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_f60d, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100c_f613, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_f616, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_f619, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f61c, 4);  cmp(memd[ds, eax + 20], 0);           /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_f620, 2);  if(jz(0x100c_f64c, 0x2a)) goto l_0x100c_f64c;/* jz 0x100cf64c */
            ii(0x100c_f622, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f625, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100c_f628, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100c_f62b, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100c_f62f, 2);  if(jz(0x100c_f645, 0x14)) goto l_0x100c_f645;/* jz 0x100cf645 */
            ii(0x100c_f631, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_f633, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100c_f636, 5);  call(Definitions.my_dtor_d3, 0x86f8); /* call 0x100d7d33 */
            ii(0x100c_f63b, 5);  call(Definitions.sys_delete, 0x9_6924);/* call 0x10165f64 */
            ii(0x100c_f640, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_f643, 2);  jmp(0x100c_f64c, 7); goto l_0x100c_f64c;/* jmp 0x100cf64c */
        l_0x100c_f645:
            ii(0x100c_f645, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x100c_f64c:
            ii(0x100c_f64c, 5);  mov(eax, 0xd);                        /* mov eax, 0xd */
            ii(0x100c_f651, 5);  call(Definitions.sys_new, 0x9_67aa);  /* call 0x10165e00 */
            ii(0x100c_f656, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_f659, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_f65c, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_f65f, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x100c_f663, 2);  if(jz(0x100c_f69d, 0x38)) goto l_0x100c_f69d;/* jz 0x100cf69d */
            ii(0x100c_f665, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f668, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f66b, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f66e, 1);  push(eax);                            /* push eax */
            ii(0x100c_f66f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f672, 3);  mov(ecx, memd[ds, eax + 6]);          /* mov ecx, [eax+0x6] */
            ii(0x100c_f675, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x100c_f678, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f67b, 3);  mov(ebx, memd[ds, eax + 4]);          /* mov ebx, [eax+0x4] */
            ii(0x100c_f67e, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x100c_f681, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f684, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100c_f687, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x100c_f68a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_f68d, 5);  call(0x100d_7bdc, 0x854a);            /* call 0x100d7bdc */
            ii(0x100c_f692, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_f695, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_f698, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x100c_f69b, 2);  jmp(0x100c_f6a3, 6); goto l_0x100c_f6a3;/* jmp 0x100cf6a3 */
        l_0x100c_f69d:
            ii(0x100c_f69d, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_f6a0, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
        l_0x100c_f6a3:
            ii(0x100c_f6a3, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100c_f6a6, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_f6a9, 3);  mov(memd[ds, edx + 20], eax);         /* mov [edx+0x14], eax */
            ii(0x100c_f6ac, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f6af, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f6b2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f6b5, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6b6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f6b9, 3);  mov(eax, memd[ds, eax + 20]);         /* mov eax, [eax+0x14] */
            ii(0x100c_f6bc, 5);  call(0x100d_4e8c, 0x57cb);            /* call 0x100d4e8c */
            ii(0x100c_f6c1, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6c2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f6c5, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f6c8, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f6cb, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6cc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f6cf, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_f6d2, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f6d5, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6d6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f6d9, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x100c_f6dc, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_f6df, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6e0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f6e3, 1);  push(eax);                            /* push eax */
            ii(0x100c_f6e4, 5);  call(/* sys */ 0x1016_abbc, 0x9_b4d3);/* call 0x1016abbc */
            ii(0x100c_f6e9, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x100c_f6ec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_f6ee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_f6ef, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_f6f0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_f6f1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_f6f2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_f6f3, 1);  ret();                                /* ret */
        }
    }
}
