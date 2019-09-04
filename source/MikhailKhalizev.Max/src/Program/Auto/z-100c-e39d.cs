using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_e39d-c6177cf9")]
        public void Method_100c_e39d()
        {
            ii(0x100c_e39d, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_e3a2, 5); call(Definitions.sys_check_available_stack_size, 0x9_79ab); /* call 0x10165d52 */
            ii(0x100c_e3a7, 1); push(esi);                              /* push esi */
            ii(0x100c_e3a8, 1); push(edi);                              /* push edi */
            ii(0x100c_e3a9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_e3aa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_e3ac, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100c_e3b2, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_e3b5, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x100c_e3b8, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100c_e3bb, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x100c_e3be, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e3c1, 5); call(0x100c_e2fc, -0xca);               /* call 0x100ce2fc */
            ii(0x100c_e3c6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_e3c9, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e3cc, 4); mov(memw[ds, edx + 4], ax);             /* mov [edx+0x4], ax */
            ii(0x100c_e3d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_e3d3, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e3d6, 4); mov(memw[ds, edx + 6], ax);             /* mov [edx+0x6], ax */
            ii(0x100c_e3da, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_e3dd, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e3e0, 4); mov(memw[ds, edx + 8], ax);             /* mov [edx+0x8], ax */
            ii(0x100c_e3e4, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x100c_e3e7, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x100c_e3ea, 4); mov(memw[ds, edx + 10], ax);            /* mov [edx+0xa], ax */
            ii(0x100c_e3ee, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e3f1, 4); mov(memb[ds, eax + 40], 1);             /* mov byte [eax+0x28], 0x1 */
            ii(0x100c_e3f5, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e3f8, 6); mov(memw[ds, eax + 53], 0xffff);        /* mov word [eax+0x35], 0xffff */
            ii(0x100c_e3fe, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100c_e401, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_e404, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_e407, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_e409, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_e40a, 1); pop(edi);                               /* pop edi */
            ii(0x100c_e40b, 1); pop(esi);                               /* pop esi */
            ii(0x100c_e40c, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
