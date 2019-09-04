using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9662-adeb6072")]
        public void my_ctor_c4()
        {
            ii(0x1009_9662, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_9667, 5); call(Definitions.sys_check_available_stack_size, 0xc_c6e6); /* call 0x10165d52 */
            ii(0x1009_966c, 1); push(ecx);                              /* push ecx */
            ii(0x1009_966d, 1); push(esi);                              /* push esi */
            ii(0x1009_966e, 1); push(edi);                              /* push edi */
            ii(0x1009_966f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9670, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9672, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_9678, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_967b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_967e, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_9681, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_9684, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_9687, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_968a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1009_968d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_9690, 3); call_abs(memd[ds, edx + 20]);           /* call dword [edx+0x14] */
            ii(0x1009_9693, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_9696, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1009_9699, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_969c, 5); call(0x1008_ad90, -0xe911);             /* call 0x1008ad90 */
            ii(0x1009_96a1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_96a4, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_96a7, 5); call(0x100a_26d1, 0x9025);              /* call 0x100a26d1 */
            ii(0x1009_96ac, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_96af, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_96b2, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_96b5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_96b8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_96bb, 5); call(0x1009_c484, 0x2dc4);              /* call 0x1009c484 */
            ii(0x1009_96c0, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_96c3, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_96c6, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x1009_96c9, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1009_96cc, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_96cf, 7); mov(memd[ds, eax + 2], 0x101b_4500);    /* mov dword [eax+0x2], 0x101b4500 */
            ii(0x1009_96d6, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_96d9, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_96dc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_96df, 5); call(0x1009_c44c, 0x2d68);              /* call 0x1009c44c */
            ii(0x1009_96e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_96e7, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1009_96ea, 4); mov(memw[ds, edx + 23], ax);            /* mov [edx+0x17], ax */
            ii(0x1009_96ee, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_96f1, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1009_96f4, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1009_96f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_96f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_96fa, 1); pop(edi);                               /* pop edi */
            ii(0x1009_96fb, 1); pop(esi);                               /* pop esi */
            ii(0x1009_96fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_96fd, 1); ret();                                  /* ret */
        }
    }
}
