using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e9699ef4-363b-4e23-9494-9b34c685f8fd")]
        public void Method_100e_53a8()
        {
            ii(0x100e_53a8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_53ad, 5); calld(Definitions.sys_check_available_stack_size, 0x809a0); /* call 0x10165d52 */
            ii(0x100e_53b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_53b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_53b4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_53b5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_53b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_53b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_53b9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_53bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_53c2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_53c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_53c8, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100e_53cc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100e_53cf:
            ii(0x100e_53cf, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x100e_53d2, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100e_53d7, 2); if(jzd(0x100e_53ec, 0x13)) goto l_0x100e_53ec; /* jz 0x100e53ec */
            ii(0x100e_53d9, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100e_53dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_53e0, 5); calld(0x100e_866c, 0x3287);             /* call 0x100e866c */
            ii(0x100e_53e5, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x100e_53e8, 2); if(jzd(0x100e_5400, 0x16)) goto l_0x100e_5400; /* jz 0x100e5400 */
            ii(0x100e_53ea, 2); jmpd(0x100e_53cf, -0x1d); goto l_0x100e_53cf; /* jmp 0x100e53cf */
        l_0x100e_53ec:
            ii(0x100e_53ec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_53ef, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100e_53f2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100e_53f5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_53f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_53fb, 5); calld(0x100e_85fc, 0x31fc);             /* call 0x100e85fc */
        l_0x100e_5400:
            ii(0x100e_5400, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_5402, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_5403, 1); popd(edi);                              /* pop edi */
            ii(0x100e_5404, 1); popd(esi);                              /* pop esi */
            ii(0x100e_5405, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_5406, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_5407, 1); retd(); return;                         /* ret */
        }
    }
}
