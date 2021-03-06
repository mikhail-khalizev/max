using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_7d6e-df921f71")]
        public void Method_100c_7d6e()
        {
            ii(0x100c_7d6e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_7d73, 5);  call(Definitions.sys_check_available_stack_size, 0x9_dfda);/* call 0x10165d52 */
            ii(0x100c_7d78, 1);  push(esi);                            /* push esi */
            ii(0x100c_7d79, 1);  push(edi);                            /* push edi */
            ii(0x100c_7d7a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_7d7b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_7d7d, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_7d83, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_7d86, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100c_7d89, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100c_7d8c, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100c_7d8f, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x100c_7d93, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100c_7d96, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7d99, 3);  mov(eax, memd[ds, eax + 39]);         /* mov eax, [eax+0x27] */
            ii(0x100c_7d9c, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_7d9e, 4);  movsx(edx, memw[ss, ebp - 8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100c_7da2, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_7da4, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_7da6, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_7da9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_7dac, 3);  sub(memd[ss, ebp - 4], eax);          /* sub [ebp-0x4], eax */
        l_0x100c_7daf:
            ii(0x100c_7daf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_7db2, 3);  dec(memd[ss, ebp - 4]);               /* dec dword [ebp-0x4] */
            ii(0x100c_7db5, 1);  cwde();                               /* cwde */
            ii(0x100c_7db6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100c_7db8, 2);  if(jle(0x100c_7dca, 0x10)) goto l_0x100c_7dca;/* jle 0x100c7dca */
            ii(0x100c_7dba, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x100c_7dbd, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x100c_7dc0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_7dc3, 3);  mov(al, memb[ds, eax + 43]);          /* mov al, [eax+0x2b] */
            ii(0x100c_7dc6, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x100c_7dc8, 2);  jmp(0x100c_7daf, -0x1b); goto l_0x100c_7daf;/* jmp 0x100c7daf */
        l_0x100c_7dca:
            ii(0x100c_7dca, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_7dcc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_7dcd, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_7dce, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_7dcf, 1);  ret();                                /* ret */
        }
    }
}
