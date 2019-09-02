using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_6e3d-7d8e2d0d")]
        public void Method_1008_6e3d()
        {
            ii(0x1008_6e3d, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1008_6e42, 5); call(Definitions.sys_check_available_stack_size, 0xd_ef0b); /* call 0x10165d52 */
            ii(0x1008_6e47, 1); push(ebx);                              /* push ebx */
            ii(0x1008_6e48, 1); push(ecx);                              /* push ecx */
            ii(0x1008_6e49, 1); push(esi);                              /* push esi */
            ii(0x1008_6e4a, 1); push(edi);                              /* push edi */
            ii(0x1008_6e4b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_6e4c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_6e4e, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1008_6e54, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_6e57, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_6e5a, 5); mov(ecx, 0x2500);                       /* mov ecx, 0x2500 */
            ii(0x1008_6e5f, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1008_6e62, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_6e65, 5); call(0x1008_ad90, 0x3f26);              /* call 0x1008ad90 */
            ii(0x1008_6e6a, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_6e6d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6e70, 5); call(0x100a_26d1, 0x1_b85c);            /* call 0x100a26d1 */
            ii(0x1008_6e75, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_6e78, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_6e7b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_6e7e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6e81, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_6e84, 5); call(Definitions.my_ctor_0x101b_56fc, 0x1df3); /* call 0x10088c7c */
            ii(0x1008_6e89, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1008_6e8c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_6e8f, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_6e92, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_6e95, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6e98, 7); mov(memd[ds, eax + 2], 0x101b_3bf0);    /* mov dword [eax+0x2], 0x101b3bf0 */
            ii(0x1008_6e9f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6ea2, 7); mov(memd[ds, eax + 33], 0);             /* mov dword [eax+0x21], 0x0 */
            ii(0x1008_6ea9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6eac, 6); mov(memw[ds, eax + 29], 0xffff);        /* mov word [eax+0x1d], 0xffff */
            ii(0x1008_6eb2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6eb5, 6); mov(memw[ds, eax + 31], 0xffff);        /* mov word [eax+0x1f], 0xffff */
            ii(0x1008_6ebb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_6ebe, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_6ec1, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_6ec4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_6ec6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_6ec7, 1); pop(edi);                               /* pop edi */
            ii(0x1008_6ec8, 1); pop(esi);                               /* pop esi */
            ii(0x1008_6ec9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_6eca, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_6ecb, 1); ret();                                  /* ret */
        }
    }
}
