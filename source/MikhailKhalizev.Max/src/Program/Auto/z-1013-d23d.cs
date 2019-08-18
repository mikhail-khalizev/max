using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("49c7e5b5-bb0f-4114-a5c6-a17c67a740ad")]
        public void Method_1013_d23d()
        {
            ii(0x1013_d23d, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_d242, 5); calld(Definitions.sys_check_available_stack_size, 0x2_8b0b); /* call 0x10165d52 */
            ii(0x1013_d247, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_d248, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_d249, 1); pushd(edx);                             /* push edx */
            ii(0x1013_d24a, 1); pushd(esi);                             /* push esi */
            ii(0x1013_d24b, 1); pushd(edi);                             /* push edi */
            ii(0x1013_d24c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_d24d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_d24f, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_d255, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_d258, 7); mov(memd_a32[ss, ebp - 0x8], 0x14);     /* mov dword [ebp-0x8], 0x14 */
        l_0x1013_d25f:
            ii(0x1013_d25f, 3); dec(memd_a32[ss, ebp - 0x8]);           /* dec dword [ebp-0x8] */
            ii(0x1013_d262, 5); cmp(memw_a32[ss, ebp - 0x8], -0x1 /* 0xff */); /* cmp word [ebp-0x8], 0xffff */
            ii(0x1013_d267, 2); if(jzd(0x1013_d2bb, 0x52)) goto l_0x1013_d2bb; /* jz 0x1013d2bb */
            ii(0x1013_d269, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1013_d26d, 6); imul(eax, eax, 0x91);                   /* imul eax, eax, 0x91 */
            ii(0x1013_d273, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_d276, 6); add(edx, 0x251);                        /* add edx, 0x251 */
            ii(0x1013_d27c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_d27e, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1013_d281, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d284, 6); cmp(memd_a32[ds, eax], 0xffff);         /* cmp dword [eax], 0xffff */
            ii(0x1013_d28a, 2); if(jzd(0x1013_d2b9, 0x2d)) goto l_0x1013_d2b9; /* jz 0x1013d2b9 */
            ii(0x1013_d28c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d28f, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_d291, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d294, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_d297, 5); calld(/* sys */ 0x1018_0ace, 0x4_3832); /* call 0x10180ace */
            ii(0x1013_d29c, 5); mov(edx, 0xffff);                       /* mov edx, 0xffff */
            ii(0x1013_d2a1, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1013_d2a3, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
            ii(0x1013_d2a6, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1013_d2a9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_d2ac, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1013_d2ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_d2b1, 3); mov(eax, memd_a32[ds, eax + 0x1c]);     /* mov eax, [eax+0x1c] */
            ii(0x1013_d2b4, 5); calld(/* sys */ 0x1018_0a4a, 0x4_3791); /* call 0x10180a4a */
        l_0x1013_d2b9:
            ii(0x1013_d2b9, 2); jmpd(0x1013_d25f, -0x5c); goto l_0x1013_d25f; /* jmp 0x1013d25f */
        l_0x1013_d2bb:
            ii(0x1013_d2bb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_d2bd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_d2be, 1); popd(edi);                              /* pop edi */
            ii(0x1013_d2bf, 1); popd(esi);                              /* pop esi */
            ii(0x1013_d2c0, 1); popd(edx);                              /* pop edx */
            ii(0x1013_d2c1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_d2c2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_d2c3, 1); retd(); return;                         /* ret */
        }
    }
}
