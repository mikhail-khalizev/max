using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6751-f2e27ca3")]
        public void Method_100d_6751()
        {
            ii(0x100d_6751, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_6756, 5);  call(Definitions.sys_check_available_stack_size, 0x8_f5f7);/* call 0x10165d52 */
            ii(0x100d_675b, 1);  push(esi);                            /* push esi */
            ii(0x100d_675c, 1);  push(edi);                            /* push edi */
            ii(0x100d_675d, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_675e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_6760, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100d_6766, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_6769, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x100d_676c, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100d_676f, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100d_6772, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_6775, 7);  mov(memd[ds, eax + 19], 0x101b_5f98); /* mov dword [eax+0x13], 0x101b5f98 */
            ii(0x100d_677c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_677f, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x100d_6785, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_6788, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_678b, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x100d_678f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6792, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_6795, 4);  mov(memw[ds, edx + 6], ax);           /* mov [edx+0x6], ax */
            ii(0x100d_6799, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_679c, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_679f, 4);  mov(memw[ds, edx + 8], ax);           /* mov [edx+0x8], ax */
            ii(0x100d_67a3, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_67a6, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_67a9, 4);  mov(memw[ds, edx + 10], ax);          /* mov [edx+0xa], ax */
            ii(0x100d_67ad, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_67b0, 7);  mov(memd[ds, eax + 12], 0);           /* mov dword [eax+0xc], 0x0 */
            ii(0x100d_67b7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_67ba, 4);  mov(memb[ds, eax + 18], 0);           /* mov byte [eax+0x12], 0x0 */
            ii(0x100d_67be, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_67c1, 6);  mov(memw[ds, eax + 16], 0xffff);      /* mov word [eax+0x10], 0xffff */
            ii(0x100d_67c7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_67ca, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_67cd, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_67d0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_67d2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_67d3, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_67d4, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_67d5, 3);  ret(4);                               /* ret 0x4 */
        }
    }
}
