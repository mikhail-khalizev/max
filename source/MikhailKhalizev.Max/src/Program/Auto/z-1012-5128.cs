using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8eb7bc63-2b82-44ae-a4dd-0b9251f7c23e")]
        public void Method_1012_5128()
        {
            ii(0x1012_5128, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1012_512d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_0c20); /* call 0x10165d52 */
            ii(0x1012_5132, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5133, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5134, 1); pushd(edx);                             /* push edx */
            ii(0x1012_5135, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5136, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5137, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5138, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_513a, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1012_5140, 7); mov(memd_a32[ss, ebp - 0x28], 0x2);     /* mov dword [ebp-0x28], 0x2 */
            ii(0x1012_5147, 7); mov(memd_a32[ss, ebp - 0x24], 0x40);    /* mov dword [ebp-0x24], 0x40 */
            ii(0x1012_514e, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x1012_5151, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1012_5154, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x1012_5159, 5); calld(/* sys */ 0x1016_c606, 0x4_74a8); /* call 0x1016c606 */
            ii(0x1012_515e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1012_5161, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_5164, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_5166, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_5169, 4); mov(memw_a32[ss, ebp - 0x8], ax);       /* mov [ebp-0x8], ax */
            ii(0x1012_516d, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1012_5170, 4); lgs(edx, ss, ebp - 0xc);                /* lgs edx, [ebp-0xc] */
            ii(0x1012_5174, 4); mov(ax, memw_a32[gs, edx]);             /* mov ax, [gs:edx] */
            ii(0x1012_5178, 6); mov(memw_a32[ds, 0x101c_5992], ax);     /* mov [0x101c5992], ax */
            ii(0x1012_517e, 4); lgs(edx, ss, ebp - 0xc);                /* lgs edx, [ebp-0xc] */
            ii(0x1012_5182, 5); mov(ax, memw_a32[gs, edx + 0x2]);       /* mov ax, [gs:edx+0x2] */
            ii(0x1012_5187, 6); mov(memw_a32[ds, 0x101c_5994], ax);     /* mov [0x101c5994], ax */
            ii(0x1012_518d, 4); lgs(edx, ss, ebp - 0xc);                /* lgs edx, [ebp-0xc] */
            ii(0x1012_5191, 5); mov(ax, memw_a32[gs, edx + 0x4]);       /* mov ax, [gs:edx+0x4] */
            ii(0x1012_5196, 6); mov(memw_a32[ds, 0x101c_5996], ax);     /* mov [0x101c5996], ax */
            ii(0x1012_519c, 4); lgs(edx, ss, ebp - 0xc);                /* lgs edx, [ebp-0xc] */
            ii(0x1012_51a0, 5); mov(ax, memw_a32[gs, edx + 0x6]);       /* mov ax, [gs:edx+0x6] */
            ii(0x1012_51a5, 6); mov(memw_a32[ds, 0x101c_5998], ax);     /* mov [0x101c5998], ax */
            ii(0x1012_51ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_51ad, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_51ae, 1); popd(edi);                              /* pop edi */
            ii(0x1012_51af, 1); popd(esi);                              /* pop esi */
            ii(0x1012_51b0, 1); popd(edx);                              /* pop edx */
            ii(0x1012_51b1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_51b2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_51b3, 1); retd(); return;                         /* ret */
        }
    }
}
