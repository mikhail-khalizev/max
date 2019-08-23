using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9ee1-8e73ef0d")]
        public void my_ctor_c8()
        {
            ii(0x1009_9ee1, 5); push(0x30);                             /* push 0x30 */
            ii(0x1009_9ee6, 5); call(Definitions.sys_check_available_stack_size, 0xc_be67); /* call 0x10165d52 */
            ii(0x1009_9eeb, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9eec, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9eed, 1); push(esi);                              /* push esi */
            ii(0x1009_9eee, 1); push(edi);                              /* push edi */
            ii(0x1009_9eef, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9ef0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9ef2, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_9ef8, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9efb, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_9efe, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9f01, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_9f04, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9f07, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_9f0a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_9f0d, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1009_9f10, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_9f13, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1009_9f16, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_9f19, 5); call(0x1008_ad90, -0xf18e);             /* call 0x1008ad90 */
            ii(0x1009_9f1e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_9f21, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9f24, 5); call(0x100a_26d1, 0x87a8);              /* call 0x100a26d1 */
            ii(0x1009_9f29, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9f2c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9f2f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_9f32, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9f35, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9f38, 5); call(0x1009_c484, 0x2547);              /* call 0x1009c484 */
            ii(0x1009_9f3d, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_9f40, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_9f43, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_9f46, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9f49, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9f4c, 7); mov(memd[ds, eax + 0x2], 0x101b_4340);  /* mov dword [eax+0x2], 0x101b4340 */
            ii(0x1009_9f53, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_9f56, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9f59, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9f5c, 5); call(0x1009_c44c, 0x24eb);              /* call 0x1009c44c */
            ii(0x1009_9f61, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_9f64, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_9f67, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_9f6a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9f6c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9f6d, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9f6e, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9f6f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9f70, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9f71, 1); ret();                                  /* ret */
        }
    }
}
