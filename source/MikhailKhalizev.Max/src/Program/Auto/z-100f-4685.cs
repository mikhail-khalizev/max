using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("68c7b0ce-d84a-45fa-be7f-08d5b94d061a")]
        public void Method_100f_4685()
        {
            ii(0x100f_4685, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100f_468a, 5); calld(Definitions.sys_check_available_stack_size, 0x716c3); /* call 0x10165d52 */
            ii(0x100f_468f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4690, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4691, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4692, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4693, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4694, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4695, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4697, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_469d, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x100f_46a0, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100f_46a4, 6); if(jzd(0x100f_472d, 0x83)) goto l_0x100f_472d; /* jz 0x100f472d */
            ii(0x100f_46aa, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100f_46b1, 6); mov(ax, memw_a32[ds, 0x101c_38e2]);     /* mov ax, [0x101c38e2] */
            ii(0x100f_46b7, 7); cmp(ax, memw_a32[ds, 0x101c_38e6]);     /* cmp ax, [0x101c38e6] */
            ii(0x100f_46be, 2); if(jgd(0x100f_46cc, 0xc)) goto l_0x100f_46cc; /* jg 0x100f46cc */
            ii(0x100f_46c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_46c3, 7); sub(memw_a32[ds, 0x101c_38e6], ax);     /* sub [0x101c38e6], ax */
            ii(0x100f_46ca, 2); jmpd(0x100f_46ee, 0x22); goto l_0x100f_46ee; /* jmp 0x100f46ee */
        l_0x100f_46cc:
            ii(0x100f_46cc, 5); mov(eax, memd_a32[ds, 0x101c_38e4]);    /* mov eax, [0x101c38e4] */
            ii(0x100f_46d1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_46d4, 6); mov(edx, memd_a32[ds, 0x101c_38e0]);    /* mov edx, [0x101c38e0] */
            ii(0x100f_46da, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_46dd, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100f_46e0, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_46e2, 2); if(jld(0x100f_46ee, 0xa)) goto l_0x100f_46ee; /* jl 0x100f46ee */
            ii(0x100f_46e4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_46e7, 7); add(memw_a32[ds, 0x101c_38e6], ax);     /* add [0x101c38e6], ax */
        l_0x100f_46ee:
            ii(0x100f_46ee, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x100f_46f4, 7); cmp(ax, memw_a32[ds, 0x101c_38e8]);     /* cmp ax, [0x101c38e8] */
            ii(0x100f_46fb, 2); if(jgd(0x100f_4709, 0xc)) goto l_0x100f_4709; /* jg 0x100f4709 */
            ii(0x100f_46fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_4700, 7); sub(memw_a32[ds, 0x101c_38e8], ax);     /* sub [0x101c38e8], ax */
            ii(0x100f_4707, 2); jmpd(0x100f_472b, 0x22); goto l_0x100f_472b; /* jmp 0x100f472b */
        l_0x100f_4709:
            ii(0x100f_4709, 5); mov(eax, memd_a32[ds, 0x101c_38e6]);    /* mov eax, [0x101c38e6] */
            ii(0x100f_470e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_4711, 6); mov(edx, memd_a32[ds, 0x101c_38e2]);    /* mov edx, [0x101c38e2] */
            ii(0x100f_4717, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_471a, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x100f_471d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_471f, 2); if(jld(0x100f_472b, 0xa)) goto l_0x100f_472b; /* jl 0x100f472b */
            ii(0x100f_4721, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_4724, 7); add(memw_a32[ds, 0x101c_38e8], ax);     /* add [0x101c38e8], ax */
        l_0x100f_472b:
            ii(0x100f_472b, 2); jmpd(0x100f_474b, 0x1e); goto l_0x100f_474b; /* jmp 0x100f474b */
        l_0x100f_472d:
            ii(0x100f_472d, 6); mov(ax, memw_a32[ds, 0x101c_38e2]);     /* mov ax, [0x101c38e2] */
            ii(0x100f_4733, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x100f_4736, 6); mov(memw_a32[ds, 0x101c_38e6], ax);     /* mov [0x101c38e6], ax */
            ii(0x100f_473c, 6); mov(ax, memw_a32[ds, 0x101c_38e4]);     /* mov ax, [0x101c38e4] */
            ii(0x100f_4742, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x100f_4745, 6); mov(memw_a32[ds, 0x101c_38e8], ax);     /* mov [0x101c38e8], ax */
        l_0x100f_474b:
            ii(0x100f_474b, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x100f_4750, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4752, 5); mov(eax, memd_a32[ds, 0x101c_38e4]);    /* mov eax, [0x101c38e4] */
            ii(0x100f_4757, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_475a, 5); calld(0x1007_6e7c, -0x7d8e3);           /* call 0x10076e7c */
            ii(0x100f_475f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_4761, 5); calld(Definitions.my_min, -0x6afe2);    /* call 0x10089784 */
            ii(0x100f_4766, 6); mov(memw_a32[ds, 0x101c_38e6], ax);     /* mov [0x101c38e6], ax */
            ii(0x100f_476c, 5); mov(ebx, 0x38);                         /* mov ebx, 0x38 */
            ii(0x100f_4771, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4773, 5); mov(eax, memd_a32[ds, 0x101c_38e6]);    /* mov eax, [0x101c38e6] */
            ii(0x100f_4778, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_477b, 5); calld(0x1007_6e7c, -0x7d904);           /* call 0x10076e7c */
            ii(0x100f_4780, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_4782, 5); calld(Definitions.my_min, -0x6b003);    /* call 0x10089784 */
            ii(0x100f_4787, 6); mov(memw_a32[ds, 0x101c_38e8], ax);     /* mov [0x101c38e8], ax */
            ii(0x100f_478d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_478f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4790, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4791, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4792, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4793, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_4794, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_4795, 1); retd(); return;                         /* ret */
        }
    }
}
