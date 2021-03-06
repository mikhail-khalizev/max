using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_2b35-aba76e3f")]
        public void Method_100c_2b35()
        {
            ii(0x100c_2b35, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_2b3a, 5);  call(Definitions.sys_check_available_stack_size, 0xa_3213);/* call 0x10165d52 */
            ii(0x100c_2b3f, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_2b40, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_2b41, 1);  push(esi);                            /* push esi */
            ii(0x100c_2b42, 1);  push(edi);                            /* push edi */
            ii(0x100c_2b43, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_2b44, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_2b46, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_2b4c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_2b4f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_2b52, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_2b55, 4);  cmp(memd[ds, eax + 103], 0);          /* cmp dword [eax+0x67], 0x0 */
            ii(0x100c_2b59, 2);  if(jz(0x100c_2b7d, 0x22)) goto l_0x100c_2b7d;/* jz 0x100c2b7d */
            ii(0x100c_2b5b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_2b5e, 3);  movsx(eax, memw[ds, eax]);            /* movsx eax, word [eax] */
            ii(0x100c_2b61, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100c_2b64, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x100c_2b66, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_2b69, 3);  mov(edx, memd[ds, eax + 103]);        /* mov edx, [eax+0x67] */
            ii(0x100c_2b6c, 2);  add(edx, ebx);                        /* add edx, ebx */
            ii(0x100c_2b6e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_2b71, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_2b73, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_2b76, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
            ii(0x100c_2b78, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_2b7a, 3);  mov(memb[ds, eax], 0xff);             /* mov byte [eax], 0xff */
        l_0x100c_2b7d:
            ii(0x100c_2b7d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_2b7f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_2b80, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_2b81, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_2b82, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_2b83, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_2b84, 1);  ret();                                /* ret */
        }
    }
}
