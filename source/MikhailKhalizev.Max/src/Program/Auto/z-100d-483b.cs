using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_483b-26344ead")]
        public void Method_100d_483b()
        {
            ii(0x100d_483b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_4840, 5);  call(Definitions.sys_check_available_stack_size, 0x9_150d);/* call 0x10165d52 */
            ii(0x100d_4845, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_4846, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_4847, 1);  push(esi);                            /* push esi */
            ii(0x100d_4848, 1);  push(edi);                            /* push edi */
            ii(0x100d_4849, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_484a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_484c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_4852, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_4855, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_4858, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_485b, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_485e, 7);  cmp(ax, memw[ds, edx + 139]);         /* cmp ax, [edx+0x8b] */
            ii(0x100d_4865, 2);  if(jnz(0x100d_4877, 0x10)) goto l_0x100d_4877;/* jnz 0x100d4877 */
            ii(0x100d_4867, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_486a, 3);  mov(edx, memd[ds, eax + 49]);         /* mov edx, [eax+0x31] */
            ii(0x100d_486d, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_486f, 3);  mov(al, memb[ds, edx + 69]);          /* mov al, [edx+0x45] */
            ii(0x100d_4872, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_4875, 2);  jmp(0x100d_4891, 0x1a); goto l_0x100d_4891;/* jmp 0x100d4891 */
        l_0x100d_4877:
            ii(0x100d_4877, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_487a, 3);  mov(eax, memd[ds, eax + 49]);         /* mov eax, [eax+0x31] */
            ii(0x100d_487d, 3);  mov(al, memb[ds, eax + 38]);          /* mov al, [eax+0x26] */
            ii(0x100d_4880, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x100d_4882, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100d_4885, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_4889, 5);  call(0x100d_4b64, 0x2d6);             /* call 0x100d4b64 */
            ii(0x100d_488e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x100d_4891:
            ii(0x100d_4891, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_4894, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_4896, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_4897, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_4898, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_4899, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_489a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_489b, 1);  ret();                                /* ret */
        }
    }
}
