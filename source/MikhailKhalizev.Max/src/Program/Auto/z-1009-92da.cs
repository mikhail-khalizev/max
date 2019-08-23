using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_92da-77e50dad")]
        public void Method_1009_92da()
        {
            ii(0x1009_92da, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1009_92df, 5); calld(Definitions.sys_check_available_stack_size, 0xc_ca6e); /* call 0x10165d52 */
            ii(0x1009_92e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_92e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_92e6, 1); pushd(esi);                             /* push esi */
            ii(0x1009_92e7, 1); pushd(edi);                             /* push edi */
            ii(0x1009_92e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_92e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_92eb, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_92f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_92f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_92f7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_92fa, 4); cmp(memb_a32[ds, eax + 0x1d], 0x5);     /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_92fe, 2); if(jzd(0x1009_9310, 0x10)) goto l_0x1009_9310; /* jz 0x10099310 */
            ii(0x1009_9300, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9303, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1009_9307, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_930a, 4); cmp(dx, memw_a32[ds, eax + 0x13]);      /* cmp dx, [eax+0x13] */
            ii(0x1009_930e, 2); if(jzd(0x1009_9312, 0x2)) goto l_0x1009_9312; /* jz 0x10099312 */
        l_0x1009_9310:
            ii(0x1009_9310, 2); jmpd(0x1009_9327, 0x15); goto l_0x1009_9327; /* jmp 0x10099327 */
        l_0x1009_9312:
            ii(0x1009_9312, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9315, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_9318, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_931b, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_931e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_9321, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_9324, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
        l_0x1009_9327:
            ii(0x1009_9327, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_932a, 4); cmp(memb_a32[ds, eax + 0x1d], 0x5);     /* cmp byte [eax+0x1d], 0x5 */
            ii(0x1009_932e, 2); if(jzd(0x1009_9342, 0x12)) goto l_0x1009_9342; /* jz 0x10099342 */
            ii(0x1009_9330, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_9333, 3); add(edx, 0x15);                         /* add edx, 0x15 */
            ii(0x1009_9336, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9339, 5); calld(0x1007_6d98, -0x2_25a6);          /* call 0x10076d98 */
            ii(0x1009_933e, 2); test(al, al);                           /* test al, al */
            ii(0x1009_9340, 2); if(jnzd(0x1009_9344, 0x2)) goto l_0x1009_9344; /* jnz 0x10099344 */
        l_0x1009_9342:
            ii(0x1009_9342, 2); jmpd(0x1009_9356, 0x12); goto l_0x1009_9356; /* jmp 0x10099356 */
        l_0x1009_9344:
            ii(0x1009_9344, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9347, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_934a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_934d, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_9350, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_9353, 3); calld_abs(memd_a32[ds, edx + 0x34]);    /* call dword [edx+0x34] */
        l_0x1009_9356:
            ii(0x1009_9356, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_935a, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_935d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_935f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9360, 1); popd(edi);                              /* pop edi */
            ii(0x1009_9361, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9362, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9363, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_9364, 1); retd();                                 /* ret */
        }
    }
}
