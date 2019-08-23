using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_d5b5-36aed61c")]
        public void Method_100c_d5b5()
        {
            ii(0x100c_d5b5, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100c_d5ba, 5); calld(Definitions.sys_check_available_stack_size, 0x9_8793); /* call 0x10165d52 */
            ii(0x100c_d5bf, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_d5c0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_d5c1, 1); pushd(edx);                             /* push edx */
            ii(0x100c_d5c2, 1); pushd(esi);                             /* push esi */
            ii(0x100c_d5c3, 1); pushd(edi);                             /* push edi */
            ii(0x100c_d5c4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_d5c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_d5c7, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_d5cd, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_d5d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d5d3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d5d6, 5); calld(0x1007_65d0, -0x5_700b);          /* call 0x100765d0 */
            ii(0x100c_d5db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_d5dd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d5e0, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_d5e3, 5); calld(0x1007_6574, -0x5_7074);          /* call 0x10076574 */
            ii(0x100c_d5e8, 5); calld(0x1008_a998, -0x4_2c55);          /* call 0x1008a998 */
            ii(0x100c_d5ed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d5f0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d5f3, 5); calld(0x1007_65d0, -0x5_7028);          /* call 0x100765d0 */
            ii(0x100c_d5f8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_d5fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d5fd, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100c_d600, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d603, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100c_d609, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100c_d60e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_d610, 5); calld(0x100c_343a, -0xa1db);            /* call 0x100c343a */
            ii(0x100c_d615, 2); test(al, al);                           /* test al, al */
            ii(0x100c_d617, 2); if(jzd(0x100c_d632, 0x19)) goto l_0x100c_d632; /* jz 0x100cd632 */
            ii(0x100c_d619, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_d61b, 5); mov(edx, 0x1c);                         /* mov edx, 0x1c */
            ii(0x100c_d620, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d623, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_d626, 5); calld(0x1007_65d0, -0x5_705b);          /* call 0x100765d0 */
            ii(0x100c_d62b, 5); calld(0x1016_3053, 0x9_5a23);           /* call 0x10163053 */
            ii(0x100c_d630, 2); jmpd(0x100c_d673, 0x41); goto l_0x100c_d673; /* jmp 0x100cd673 */
        l_0x100c_d632:
            ii(0x100c_d632, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d635, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d638, 5); calld(0x1007_6574, -0x5_70c9);          /* call 0x10076574 */
            ii(0x100c_d63d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_d63f, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x100c_d642, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d645, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_d648, 5); calld(0x1007_6574, -0x5_70d9);          /* call 0x10076574 */
            ii(0x100c_d64d, 5); calld(0x1007_623c, -0x5_7416);          /* call 0x1007623c */
            ii(0x100c_d652, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x100c_d655, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_d658, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_d65a, 2); if(jged(0x100c_d673, 0x17)) goto l_0x100c_d673; /* jge 0x100cd673 */
            ii(0x100c_d65c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_d65e, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x100c_d663, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_d666, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_d669, 5); calld(0x1007_65d0, -0x5_709e);          /* call 0x100765d0 */
            ii(0x100c_d66e, 5); calld(0x1016_3053, 0x9_59e0);           /* call 0x10163053 */
        l_0x100c_d673:
            ii(0x100c_d673, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_d675, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_d676, 1); popd(edi);                              /* pop edi */
            ii(0x100c_d677, 1); popd(esi);                              /* pop esi */
            ii(0x100c_d678, 1); popd(edx);                              /* pop edx */
            ii(0x100c_d679, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_d67a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_d67b, 1); retd();                                 /* ret */
        }
    }
}
