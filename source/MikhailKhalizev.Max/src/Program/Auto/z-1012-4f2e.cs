using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce5d8737-13de-44a0-a1b9-0544fb6e158e")]
        public void Method_1012_4f2e()
        {
            ii(0x1012_4f2e, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x1012_4f33, 5); calld(Definitions.sys_check_available_stack_size, 0x40e1a); /* call 0x10165d52 */
            ii(0x1012_4f38, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4f39, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_4f3a, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4f3b, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4f3c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4f3d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4f3f, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1012_4f45, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_4f48, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_4f4b, 7); mov(memd_a32[ss, ebp - 0x24], 0x100);   /* mov dword [ebp-0x24], 0x100 */
            ii(0x1012_4f52, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4f55, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1012_4f58, 3); shr(eax, 0x4);                          /* shr eax, 0x4 */
            ii(0x1012_4f5b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_4f5e, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1012_4f61, 3); lea(edx, ebp - 0x24);                   /* lea edx, [ebp-0x24] */
            ii(0x1012_4f64, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_4f69, 5); calld(/* sys */ 0x1016_c606, 0x47698);  /* call 0x1016c606 */
            ii(0x1012_4f6e, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_4f72, 2); if(jzd(0x1012_4f7d, 0x9)) goto l_0x1012_4f7d; /* jz 0x10124f7d */
            ii(0x1012_4f74, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1012_4f7b, 2); jmpd(0x1012_4f9a, 0x1d); goto l_0x1012_4f9a; /* jmp 0x10124f9a */
        l_0x1012_4f7d:
            ii(0x1012_4f7d, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_4f81, 2); if(jzd(0x1012_4f8c, 0x9)) goto l_0x1012_4f8c; /* jz 0x10124f8c */
            ii(0x1012_4f83, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_4f86, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_4f89, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
        l_0x1012_4f8c:
            ii(0x1012_4f8c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1012_4f8f, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1012_4f94, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1012_4f97, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1012_4f9a:
            ii(0x1012_4f9a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1012_4f9d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4f9f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4fa0, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4fa1, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4fa2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4fa3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4fa4, 1); retd(); return;                         /* ret */
        }
    }
}