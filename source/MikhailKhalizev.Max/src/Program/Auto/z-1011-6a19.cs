using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c08c2e35-5660-4366-8fcc-43d4326dbba8")]
        public void Method_1011_6a19()
        {
            ii(0x1011_6a19, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_6a1e, 5); calld(Definitions.sys_check_available_stack_size, 0x4f32f); /* call 0x10165d52 */
            ii(0x1011_6a23, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_6a24, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_6a25, 1); pushd(edx);                             /* push edx */
            ii(0x1011_6a26, 1); pushd(esi);                             /* push esi */
            ii(0x1011_6a27, 1); pushd(edi);                             /* push edi */
            ii(0x1011_6a28, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_6a29, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_6a2b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_6a31, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_6a34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6a37, 4); mov(memb_a32[ds, eax + 0x31], 0);       /* mov byte [eax+0x31], 0x0 */
            ii(0x1011_6a3b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6a3e, 4); mov(memb_a32[ds, eax + 0x3f], 0);       /* mov byte [eax+0x3f], 0x0 */
        l_0x1011_6a42:
            ii(0x1011_6a42, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6a45, 4); cmp(memb_a32[ds, eax + 0x31], 0);       /* cmp byte [eax+0x31], 0x0 */
            ii(0x1011_6a49, 2); if(jnzd(0x1011_6a9b, 0x50)) goto l_0x1011_6a9b; /* jnz 0x10116a9b */
            ii(0x1011_6a4b, 5); calld(/* sys */ 0x1016_b208, 0x547b8);  /* call 0x1016b208 */
            ii(0x1011_6a50, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_6a53, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_6a56, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6a59, 5); calld(0x1011_683d, -0x221);             /* call 0x1011683d */
            ii(0x1011_6a5e, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1011_6a65, 2); if(jzd(0x1011_6a81, 0x1a)) goto l_0x1011_6a81; /* jz 0x10116a81 */
            ii(0x1011_6a67, 5); calld(0x100e_42e4, -0x32788);           /* call 0x100e42e4 */
            ii(0x1011_6a6c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_6a71, 5); calld(0x1012_8835, 0x11dbf);            /* call 0x10128835 */
            ii(0x1011_6a76, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_6a78, 2); if(jzd(0x1011_6a7f, 0x5)) goto l_0x1011_6a7f; /* jz 0x10116a7f */
            ii(0x1011_6a7a, 5); calld(0x1016_2cb8, 0x4c239);            /* call 0x10162cb8 */
        l_0x1011_6a7f:
            ii(0x1011_6a7f, 2); jmpd(0x1011_6a99, 0x18); goto l_0x1011_6a99; /* jmp 0x10116a99 */
        l_0x1011_6a81:
            ii(0x1011_6a81, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_6a84, 4); cmp(memb_a32[ds, eax + 0x3e], 0);       /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1011_6a88, 2); if(jzd(0x1011_6a99, 0xf)) goto l_0x1011_6a99; /* jz 0x10116a99 */
            ii(0x1011_6a8a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_6a8f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_6a94, 5); calld(0x1010_0e32, -0x15c67);           /* call 0x10100e32 */
        l_0x1011_6a99:
            ii(0x1011_6a99, 2); jmpd(0x1011_6a42, -0x59); goto l_0x1011_6a42; /* jmp 0x10116a42 */
        l_0x1011_6a9b:
            ii(0x1011_6a9b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_6a9d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_6a9e, 1); popd(edi);                              /* pop edi */
            ii(0x1011_6a9f, 1); popd(esi);                              /* pop esi */
            ii(0x1011_6aa0, 1); popd(edx);                              /* pop edx */
            ii(0x1011_6aa1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_6aa2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_6aa3, 1); retd(); return;                         /* ret */
        }
    }
}
