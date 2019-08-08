using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("23d145e7-7fea-4187-a774-84642dbbbf79")]
        public void Method_100c_de37()
        {
            ii(0x100c_de37, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_de3c, 5); calld(Definitions.sys_check_available_stack_size, 0x9_7f11); /* call 0x10165d52 */
            ii(0x100c_de41, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_de42, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_de43, 1); pushd(edx);                             /* push edx */
            ii(0x100c_de44, 1); pushd(esi);                             /* push esi */
            ii(0x100c_de45, 1); pushd(edi);                             /* push edi */
            ii(0x100c_de46, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_de47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_de49, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_de4f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_de52, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x100c_de57, 5); calld(0x1007_5fdc, -0x5_7e80);          /* call 0x10075fdc */
            ii(0x100c_de5c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100c_de5f, 2); if(jzd(0x100c_de67, 0x6)) goto l_0x100c_de67; /* jz 0x100cde67 */
            ii(0x100c_de61, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_de65, 2); jmpd(0x100c_deb6, 0x4f); goto l_0x100c_deb6; /* jmp 0x100cdeb6 */
        l_0x100c_de67:
            ii(0x100c_de67, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x100c_de6c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_de6f, 3); cmp(eax, 0xf);                          /* cmp eax, 0xf */
            ii(0x100c_de72, 2); if(jbed(0x100c_de7a, 0x6)) goto l_0x100c_de7a; /* jbe 0x100cde7a */
            ii(0x100c_de74, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_de78, 2); jmpd(0x100c_deb6, 0x3c); goto l_0x100c_deb6; /* jmp 0x100cdeb6 */
        l_0x100c_de7a:
            ii(0x100c_de7a, 5); mov(eax, memd_a32[ds, 0x101c_3980]);    /* mov eax, [0x101c3980] */
            ii(0x100c_de7f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_de82, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_de85, 6); mov(eax, memd_a32[ds, eax + 0x101b_7e08]); /* mov eax, [eax+0x101b7e08] */
            ii(0x100c_de8b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100c_de8e:
            ii(0x100c_de8e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_de91, 4); cmp(memw_a32[ds, eax], -0x1 /* 0xff */); /* cmp word [eax], 0xffff */
            ii(0x100c_de95, 2); if(jzd(0x100c_deb2, 0x1b)) goto l_0x100c_deb2; /* jz 0x100cdeb2 */
            ii(0x100c_de97, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_de9a, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100c_de9d, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100c_dea1, 2); if(jnzd(0x100c_dea9, 0x6)) goto l_0x100c_dea9; /* jnz 0x100cdea9 */
            ii(0x100c_dea3, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100c_dea7, 2); jmpd(0x100c_deb6, 0xd); goto l_0x100c_deb6; /* jmp 0x100cdeb6 */
        l_0x100c_dea9:
            ii(0x100c_dea9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_deac, 4); add(memd_a32[ss, ebp - 0xc], 0x2);      /* add dword [ebp-0xc], 0x2 */
            ii(0x100c_deb0, 2); jmpd(0x100c_de8e, -0x24); goto l_0x100c_de8e; /* jmp 0x100cde8e */
        l_0x100c_deb2:
            ii(0x100c_deb2, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100c_deb6:
            ii(0x100c_deb6, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_deb9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_debb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_debc, 1); popd(edi);                              /* pop edi */
            ii(0x100c_debd, 1); popd(esi);                              /* pop esi */
            ii(0x100c_debe, 1); popd(edx);                              /* pop edx */
            ii(0x100c_debf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_dec0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_dec1, 1); retd(); return;                         /* ret */
        }
    }
}
