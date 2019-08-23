using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_1489-9c186bb8")]
        public void Method_1008_1489()
        {
            ii(0x1008_1489, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_148e, 5); calld(Definitions.sys_check_available_stack_size, 0xe_48bf); /* call 0x10165d52 */
            ii(0x1008_1493, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_1494, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_1495, 1); pushd(esi);                             /* push esi */
            ii(0x1008_1496, 1); pushd(edi);                             /* push edi */
            ii(0x1008_1497, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_1498, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_149a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_14a0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_14a3, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_14a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_14a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_14ab, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_14ae, 5); calld(0x1013_ad11, 0xb_985e);           /* call 0x1013ad11 */
            ii(0x1008_14b3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_14b5, 2); if(jzd(0x1008_14c7, 0x10)) goto l_0x1008_14c7; /* jz 0x100814c7 */
            ii(0x1008_14b7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_14ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_14bd, 5); calld(0x100a_2ce8, 0x2_1826);           /* call 0x100a2ce8 */
            ii(0x1008_14c2, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_14c5, 2); jmpd(0x1008_14e7, 0x20); goto l_0x1008_14e7; /* jmp 0x100814e7 */
        l_0x1008_14c7:
            ii(0x1008_14c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_14ca, 3); add(eax, 0x2a);                         /* add eax, 0x2a */
            ii(0x1008_14cd, 5); calld(0x1008_9d7c, 0x88aa);             /* call 0x10089d7c */
            ii(0x1008_14d2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_14d5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_14d8, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_14db, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_14de, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_14e1, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1008_14e4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1008_14e7:
            ii(0x1008_14e7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_14ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_14ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_14ed, 1); popd(edi);                              /* pop edi */
            ii(0x1008_14ee, 1); popd(esi);                              /* pop esi */
            ii(0x1008_14ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_14f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_14f1, 1); retd();                                 /* ret */
        }
    }
}
