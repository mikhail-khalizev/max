using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9d5fff8b-a3ea-4b4d-b530-41726a713ab2")]
        public void /* sys */ Method_1016_6a34()
        {
            ii(0x1016_6a34, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_6a35, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_6a36, 1); pushd(edx);                             /* push edx */
            ii(0x1016_6a37, 5); calld(/* sys */ 0x1016_7dac, 0x1370);   /* call 0x10167dac */
            ii(0x1016_6a3c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_6a3e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6a40, 2); if(jzd(0x1016_6a7a, 0x38)) goto l_0x1016_6a7a; /* jz 0x10166a7a */
            ii(0x1016_6a42, 3); mov(edx, memd_a32[ds, eax + 0x2c]);     /* mov edx, [eax+0x2c] */
            ii(0x1016_6a45, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6a47, 2); if(jzd(0x1016_6a50, 0x7)) goto l_0x1016_6a50; /* jz 0x10166a50 */
            ii(0x1016_6a49, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_6a4b, 5); calld(Definitions.sys_free_internal, 0x1ba04); /* call 0x10182454 */
        l_0x1016_6a50:
            ii(0x1016_6a50, 3); mov(ecx, memd_a32[ds, ebx + 0x3c]);     /* mov ecx, [ebx+0x3c] */
            ii(0x1016_6a53, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1016_6a55, 2); if(jzd(0x1016_6a5e, 0x7)) goto l_0x1016_6a5e; /* jz 0x10166a5e */
            ii(0x1016_6a57, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1016_6a59, 5); calld(Definitions.sys_free_internal, 0x1b9f6); /* call 0x10182454 */
        l_0x1016_6a5e:
            ii(0x1016_6a5e, 3); mov(eax, memd_a32[ds, ebx + 0x30]);     /* mov eax, [ebx+0x30] */
            ii(0x1016_6a61, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6a63, 2); if(jzd(0x1016_6a73, 0xe)) goto l_0x1016_6a73; /* jz 0x10166a73 */
        l_0x1016_6a65:
            ii(0x1016_6a65, 3); mov(edx, memd_a32[ds, eax + 0x70]);     /* mov edx, [eax+0x70] */
            ii(0x1016_6a68, 5); calld(/* sys */ 0x1016_9714, 0x2ca7);   /* call 0x10169714 */
            ii(0x1016_6a6d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_6a6f, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_6a71, 2); if(jnzd(0x1016_6a65, -0xe)) goto l_0x1016_6a65; /* jnz 0x10166a65 */
        l_0x1016_6a73:
            ii(0x1016_6a73, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_6a75, 5); calld(Definitions.sys_free_internal, 0x1b9da); /* call 0x10182454 */
        l_0x1016_6a7a:
            ii(0x1016_6a7a, 1); popd(edx);                              /* pop edx */
            ii(0x1016_6a7b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_6a7c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_6a7d, 1); retd(); return;                         /* ret */
        }
    }
}
