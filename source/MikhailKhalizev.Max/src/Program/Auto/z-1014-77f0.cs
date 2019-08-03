using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("139c7176-f676-4ce0-a5b3-cf70cec1990b")]
        public void Method_1014_77f0()
        {
            ii(0x1014_77f0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_77f5, 5); calld(Definitions.sys_check_available_stack_size, 0x1e558); /* call 0x10165d52 */
            ii(0x1014_77fa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_77fb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_77fc, 1); pushd(esi);                             /* push esi */
            ii(0x1014_77fd, 1); pushd(edi);                             /* push edi */
            ii(0x1014_77fe, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_77ff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7801, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_7807, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_780a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_780d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_7810, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7813, 5); calld(Definitions.my_string_ctor_string, -0x5d72); /* call 0x10141aa6 */
            ii(0x1014_7818, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_781b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_781e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7821, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7824, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x1014_7827, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_782a, 3); mov(memd_a32[ds, eax + 0x4], edx);      /* mov [eax+0x4], edx */
            ii(0x1014_782d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7830, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1014_7834, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7837, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1014_783b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_783e, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_7841, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_7844, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7846, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7847, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7848, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7849, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_784a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_784b, 1); retd(); return;                         /* ret */
        }
    }
}