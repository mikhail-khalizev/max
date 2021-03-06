using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a1a4-eb4507a8")]
        public void Method_1009_a1a4()
        {
            ii(0x1009_a1a4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_a1a9, 5);  call(Definitions.sys_check_available_stack_size, 0xc_bba4);/* call 0x10165d52 */
            ii(0x1009_a1ae, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_a1af, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_a1b0, 1);  push(esi);                            /* push esi */
            ii(0x1009_a1b1, 1);  push(edi);                            /* push edi */
            ii(0x1009_a1b2, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_a1b3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_a1b5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_a1bb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_a1be, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_a1c1, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_a1c3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a1c6, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a1c9, 5);  call(0x1013_ad11, 0xa_0b43);          /* call 0x1013ad11 */
            ii(0x1009_a1ce, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_a1d0, 2);  if(jz(0x1009_a1e2, 0x10)) goto l_0x1009_a1e2;/* jz 0x1009a1e2 */
            ii(0x1009_a1d2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a1d5, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a1d8, 5);  call(0x100a_2ce8, 0x8b0b);            /* call 0x100a2ce8 */
            ii(0x1009_a1dd, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_a1e0, 2);  jmp(0x1009_a22e, 0x4c); goto l_0x1009_a22e;/* jmp 0x1009a22e */
        l_0x1009_a1e2:
            ii(0x1009_a1e2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a1e5, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a1e8, 5);  call(0x1007_6574, -0x2_3c79);         /* call 0x10076574 */
            ii(0x1009_a1ed, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1009_a1f0, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_a1f3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a1f6, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1009_a1f8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a1fb, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_a1fe, 5);  call(0x1007_6574, -0x2_3c8f);         /* call 0x10076574 */
            ii(0x1009_a203, 3);  mov(edx, memd[ds, eax + 26]);         /* mov edx, [eax+0x1a] */
            ii(0x1009_a206, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1009_a209, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a20c, 3);  mov(memd[ds, eax + 4], edx);          /* mov [eax+0x4], edx */
            ii(0x1009_a20f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a212, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1009_a214, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_a215, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a218, 3);  mov(memd[ds, edx + 8], eax);          /* mov [edx+0x8], eax */
            ii(0x1009_a21b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a21e, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1009_a221, 1);  inc(eax);                             /* inc eax */
            ii(0x1009_a222, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_a225, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x1009_a228, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a22b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1009_a22e:
            ii(0x1009_a22e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_a231, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_a233, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_a234, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_a235, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_a236, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_a237, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_a238, 1);  ret();                                /* ret */
        }
    }
}
