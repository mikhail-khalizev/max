using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_dfcf-758d183a")]
        public void Method_1009_dfcf()
        {
            ii(0x1009_dfcf, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_dfd4, 5); calld(Definitions.sys_check_available_stack_size, 0xc_7d79); /* call 0x10165d52 */
            ii(0x1009_dfd9, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_dfda, 1); pushd(esi);                             /* push esi */
            ii(0x1009_dfdb, 1); pushd(edi);                             /* push edi */
            ii(0x1009_dfdc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_dfdd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_dfdf, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_dfe5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_dfe8, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_dfeb, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_dfee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_dff1, 4); inc(memw_a32[ds, eax + 0x41]);          /* inc word [eax+0x41] */
            ii(0x1009_dff5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_dff8, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1009_dffb, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_dffe, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_e001, 3); mov(ecx, memd_a32[ds, eax + 0x2]);      /* mov ecx, [eax+0x2] */
            ii(0x1009_e004, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_e007, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_e00a, 5); calld(0x1007_5e64, -0x2_81ab);          /* call 0x10075e64 */
            ii(0x1009_e00f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_e011, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_e014, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_e017, 3); calld_abs(memd_a32[ds, ecx + 0x74]);    /* call dword [ecx+0x74] */
            ii(0x1009_e01a, 2); test(al, al);                           /* test al, al */
            ii(0x1009_e01c, 2); if(jzd(0x1009_e024, 0x6)) goto l_0x1009_e024; /* jz 0x1009e024 */
            ii(0x1009_e01e, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x1009_e022, 2); jmpd(0x1009_e06b, 0x47); goto l_0x1009_e06b; /* jmp 0x1009e06b */
        l_0x1009_e024:
            ii(0x1009_e024, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e027, 4); inc(memw_a32[ds, eax + 0x43]);          /* inc word [eax+0x43] */
            ii(0x1009_e02b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_e030, 1); pushd(eax);                             /* push eax */
            ii(0x1009_e031, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e034, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1009_e036, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_e039, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_e03c, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1009_e03f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_e042, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1009_e045, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_e048, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_e04b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1009_e04e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_e051, 5); calld(0x1007_02b9, -0x2_dd9d);          /* call 0x100702b9 */
            ii(0x1009_e056, 1); cwde();                                 /* cwde */
            ii(0x1009_e057, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_e059, 2); if(jled(0x1009_e061, 0x6)) goto l_0x1009_e061; /* jle 0x1009e061 */
            ii(0x1009_e05b, 4); mov(memb_a32[ss, ebp - 0x1c], 0x1);     /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1009_e05f, 2); jmpd(0x1009_e065, 0x4); goto l_0x1009_e065; /* jmp 0x1009e065 */
        l_0x1009_e061:
            ii(0x1009_e061, 4); mov(memb_a32[ss, ebp - 0x1c], 0);       /* mov byte [ebp-0x1c], 0x0 */
        l_0x1009_e065:
            ii(0x1009_e065, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x1009_e068, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
        l_0x1009_e06b:
            ii(0x1009_e06b, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1009_e06e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_e070, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_e071, 1); popd(edi);                              /* pop edi */
            ii(0x1009_e072, 1); popd(esi);                              /* pop esi */
            ii(0x1009_e073, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_e074, 1); retd();                                 /* ret */
        }
    }
}
