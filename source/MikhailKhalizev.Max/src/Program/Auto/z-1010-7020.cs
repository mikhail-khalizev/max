using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b4155789-8de0-40cc-924c-d1a083a586e0")]
        public void Method_1010_7020()
        {
            ii(0x1010_7020, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_7025, 5); calld(Definitions.sys_check_available_stack_size, 0x5ed28); /* call 0x10165d52 */
            ii(0x1010_702a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_702b, 1); pushd(esi);                             /* push esi */
            ii(0x1010_702c, 1); pushd(edi);                             /* push edi */
            ii(0x1010_702d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_702e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7030, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_7036, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_7039, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_703c, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1010_703f, 9); mov(memw_a32[ds, 0x101c_59b6], 0);      /* mov word [0x101c59b6], 0x0 */
        l_0x1010_7048:
            ii(0x1010_7048, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1010_704b, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1010_7050, 2); if(jzd(0x1010_7066, 0x14)) goto l_0x1010_7066; /* jz 0x10107066 */
            ii(0x1010_7052, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_7055, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1010_7058, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1010_705a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_705f, 5); calld(0x100c_ddb2, -0x392b2);           /* call 0x100cddb2 */
            ii(0x1010_7064, 2); jmpd(0x1010_7048, -0x1e); goto l_0x1010_7048; /* jmp 0x10107048 */
        l_0x1010_7066:
            ii(0x1010_7066, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7068, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1010_706b, 5); calld(0x100c_ddb2, -0x392be);           /* call 0x100cddb2 */
            ii(0x1010_7070, 6); mov(ax, memw_a32[ds, 0x101c_59b6]);     /* mov ax, [0x101c59b6] */
            ii(0x1010_7076, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_7079, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_707c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_707e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_707f, 1); popd(edi);                              /* pop edi */
            ii(0x1010_7080, 1); popd(esi);                              /* pop esi */
            ii(0x1010_7081, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_7082, 1); retd(); return;                         /* ret */
        }
    }
}
