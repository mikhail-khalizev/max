using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_47af-64af34a3")]
        public void Method_1012_47af()
        {
            ii(0x1012_47af, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1012_47b4, 5); calld(Definitions.sys_check_available_stack_size, 0x4_1599); /* call 0x10165d52 */
            ii(0x1012_47b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_47ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_47bb, 1); pushd(edx);                             /* push edx */
            ii(0x1012_47bc, 1); pushd(esi);                             /* push esi */
            ii(0x1012_47bd, 1); pushd(edi);                             /* push edi */
            ii(0x1012_47be, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_47bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_47c1, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1012_47c7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_47ca, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_47d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_47d4, 5); calld(Definitions.sys_strlen, 0x4_d6ee); /* call 0x10171ec7 */
            ii(0x1012_47d9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_47dc, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_47e3:
            ii(0x1012_47e3, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_47e6, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_47e9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_47ec, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_47ef, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_47f2, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_47f4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_47f9, 5); calld(0x1012_4826, 0x28);               /* call 0x10124826 */
            ii(0x1012_47fe, 7); imul(eax, memd_a32[ds, edx + 0x101b_b420]); /* imul eax, [edx+0x101bb420] */
            ii(0x1012_4805, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1012_4808, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_480b, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1012_480e, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1012_4812, 2); if(jad(0x1012_47e3, -0x31)) goto l_0x1012_47e3; /* ja 0x101247e3 */
            ii(0x1012_4814, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_4817, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_481a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_481d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_481f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4820, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4821, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4822, 1); popd(edx);                              /* pop edx */
            ii(0x1012_4823, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4824, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_4825, 1); retd();                                 /* ret */
        }
    }
}
