using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_758a-c424d1ed")]
        public void Method_100a_758a()
        {
            ii(0x100a_758a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_758f, 5); calld(Definitions.sys_check_available_stack_size, 0xb_e7be); /* call 0x10165d52 */
            ii(0x100a_7594, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_7595, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_7596, 1); pushd(esi);                             /* push esi */
            ii(0x100a_7597, 1); pushd(edi);                             /* push edi */
            ii(0x100a_7598, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_7599, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_759b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_75a1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_75a4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_75a7, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100a_75aa, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_0abf); /* call 0x10076af0 */
            ii(0x100a_75af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_75b2, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100a_75b5, 4); mov(memw_a32[ss, ebp - 0xc], ax);       /* mov [ebp-0xc], ax */
            ii(0x100a_75b9, 2); jmpd(0x100a_75c2, 0x7); goto l_0x100a_75c2; /* jmp 0x100a75c2 */
        l_0x100a_75bb:
            ii(0x100a_75bb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_75be, 4); inc(memw_a32[ss, ebp - 0xc]);           /* inc word [ebp-0xc] */
        l_0x100a_75c2:
            ii(0x100a_75c2, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_75c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_75c9, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x100a_75cc, 2); if(jged(0x100a_7600, 0x32)) goto l_0x100a_7600; /* jge 0x100a7600 */
            ii(0x100a_75ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_75d1, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100a_75d5, 4); mov(memw_a32[ss, ebp - 0xa], ax);       /* mov [ebp-0xa], ax */
            ii(0x100a_75d9, 2); jmpd(0x100a_75e2, 0x7); goto l_0x100a_75e2; /* jmp 0x100a75e2 */
        l_0x100a_75db:
            ii(0x100a_75db, 3); mov(eax, memd_a32[ss, ebp - 0xa]);      /* mov eax, [ebp-0xa] */
            ii(0x100a_75de, 4); inc(memw_a32[ss, ebp - 0xa]);           /* inc word [ebp-0xa] */
        l_0x100a_75e2:
            ii(0x100a_75e2, 4); movsx(edx, memw_a32[ss, ebp - 0xa]);    /* movsx edx, word [ebp-0xa] */
            ii(0x100a_75e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_75e9, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x100a_75ec, 2); if(jged(0x100a_75fe, 0x10)) goto l_0x100a_75fe; /* jge 0x100a75fe */
            ii(0x100a_75ee, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100a_75f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_75f4, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100a_75f7, 5); calld(0x100a_aa64, 0x3468);             /* call 0x100aaa64 */
            ii(0x100a_75fc, 2); jmpd(0x100a_75db, -0x23); goto l_0x100a_75db; /* jmp 0x100a75db */
        l_0x100a_75fe:
            ii(0x100a_75fe, 2); jmpd(0x100a_75bb, -0x45); goto l_0x100a_75bb; /* jmp 0x100a75bb */
        l_0x100a_7600:
            ii(0x100a_7600, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_7602, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_7603, 1); popd(edi);                              /* pop edi */
            ii(0x100a_7604, 1); popd(esi);                              /* pop esi */
            ii(0x100a_7605, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_7606, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_7607, 1); retd(); return;                         /* ret */
        }
    }
}
