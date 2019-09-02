using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_0ef0-dc3d2e0a")]
        public void Method_1013_0ef0()
        {
            ii(0x1013_0ef0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_0ef5, 5); call(Definitions.sys_check_available_stack_size, 0x3_4e58); /* call 0x10165d52 */
            ii(0x1013_0efa, 1); push(ebx);                              /* push ebx */
            ii(0x1013_0efb, 1); push(ecx);                              /* push ecx */
            ii(0x1013_0efc, 1); push(esi);                              /* push esi */
            ii(0x1013_0efd, 1); push(edi);                              /* push edi */
            ii(0x1013_0efe, 1); push(ebp);                              /* push ebp */
            ii(0x1013_0eff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_0f01, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_0f07, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_0f0a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_0f0d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_0f10, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_0f13, 7); mov(memb[ds, 0x101b_b48d], 0);          /* mov byte [0x101bb48d], 0x0 */
            ii(0x1013_0f1a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0f1d, 5); call(0x1012_f003, -0x1f1f);             /* call 0x1012f003 */
            ii(0x1013_0f22, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0f25, 4); cmp(memb[ds, eax + 0x17], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_0f29, 2); if(jz(0x1013_0f34, 9)) goto l_0x1013_0f34; /* jz 0x10130f34 */
            ii(0x1013_0f2b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0f2e, 4); cmp(memb[ds, eax + 0x17], 1);           /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_0f32, 2); if(jnz(0x1013_0f41, 0xd)) goto l_0x1013_0f41; /* jnz 0x10130f41 */
        l_0x1013_0f34:
            ii(0x1013_0f34, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_0f39, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_0f3c, 5); call(0x1013_0c16, -0x32b);              /* call 0x10130c16 */
        l_0x1013_0f41:
            ii(0x1013_0f41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_0f43, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_0f44, 1); pop(edi);                               /* pop edi */
            ii(0x1013_0f45, 1); pop(esi);                               /* pop esi */
            ii(0x1013_0f46, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_0f47, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_0f48, 1); ret();                                  /* ret */
        }
    }
}
