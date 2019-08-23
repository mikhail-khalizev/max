using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_9ee6-4b521c14")]
        public void Method_1011_9ee6()
        {
            ii(0x1011_9ee6, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1011_9eeb, 5); call(Definitions.sys_check_available_stack_size, 0x4_be62); /* call 0x10165d52 */
            ii(0x1011_9ef0, 1); push(ebx);                              /* push ebx */
            ii(0x1011_9ef1, 1); push(ecx);                              /* push ecx */
            ii(0x1011_9ef2, 1); push(edx);                              /* push edx */
            ii(0x1011_9ef3, 1); push(esi);                              /* push esi */
            ii(0x1011_9ef4, 1); push(edi);                              /* push edi */
            ii(0x1011_9ef5, 1); push(ebp);                              /* push ebp */
            ii(0x1011_9ef6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_9ef8, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1011_9efe, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_9f01, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9f04, 5); call(0x1011_806d, -0x1e9c);             /* call 0x1011806d */
            ii(0x1011_9f09, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_9f0c, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_9f0f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_9f12, 5); call(0x100b_83a8, -0x6_1b6f);           /* call 0x100b83a8 */
            ii(0x1011_9f17, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1011_9f1a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9f1d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1011_9f20, 5); call(0x100b_8340, -0x6_1be5);           /* call 0x100b8340 */
            ii(0x1011_9f25, 3); sub(eax, 0x18);                         /* sub eax, 0x18 */
            ii(0x1011_9f28, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_9f2b, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_9f2e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_9f31, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9f34, 7); mov(memd[ds, eax + 0x2], 0x101b_6924);  /* mov dword [eax+0x2], 0x101b6924 */
            ii(0x1011_9f3b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9f3e, 6); mov(memw[ds, eax + 0x16], 0);           /* mov word [eax+0x16], 0x0 */
            ii(0x1011_9f44, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_9f47, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_9f4a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_9f4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_9f4f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_9f50, 1); pop(edi);                               /* pop edi */
            ii(0x1011_9f51, 1); pop(esi);                               /* pop esi */
            ii(0x1011_9f52, 1); pop(edx);                               /* pop edx */
            ii(0x1011_9f53, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_9f54, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_9f55, 1); ret();                                  /* ret */
        }
    }
}
