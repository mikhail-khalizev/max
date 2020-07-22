using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_fc5e-aa3d76e9")]
        public void Method_100c_fc5e()
        {
            ii(0x100c_fc5e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_fc63, 5);  call(Definitions.sys_check_available_stack_size, 0x9_60ea);/* call 0x10165d52 */
            ii(0x100c_fc68, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_fc69, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_fc6a, 1);  push(esi);                            /* push esi */
            ii(0x100c_fc6b, 1);  push(edi);                            /* push edi */
            ii(0x100c_fc6c, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_fc6d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_fc6f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_fc75, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_fc78, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_fc7b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_fc7e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_fc81, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_fc84, 4);  mov(memb[ds, eax + 55], 0);           /* mov byte [eax+0x37], 0x0 */
            ii(0x100c_fc88, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_fc8b, 4);  cmp(memd[ds, eax + 45], 0);           /* cmp dword [eax+0x2d], 0x0 */
            ii(0x100c_fc8f, 2);  if(jz(0x100c_fca0, 0xf)) goto l_0x100c_fca0;/* jz 0x100cfca0 */
            ii(0x100c_fc91, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_fc94, 3);  mov(edx, memd[ds, ebx + 32]);         /* mov edx, [ebx+0x20] */
            ii(0x100c_fc97, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_fc9a, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x100c_fc9d, 3);  call_abs(memd[ds, ebx + 45]);         /* call dword [ebx+0x2d] */
        l_0x100c_fca0:
            ii(0x100c_fca0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_fca2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_fca3, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_fca4, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_fca5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_fca6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_fca7, 1);  ret();                                /* ret */
        }
    }
}
