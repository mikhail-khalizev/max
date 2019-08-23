using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f600-7734ec33")]
        public void Method_100d_f600()
        {
            ii(0x100d_f600, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_f605, 5); calld(Definitions.sys_check_available_stack_size, 0x8_6748); /* call 0x10165d52 */
            ii(0x100d_f60a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_f60b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_f60c, 1); pushd(esi);                             /* push esi */
            ii(0x100d_f60d, 1); pushd(edi);                             /* push edi */
            ii(0x100d_f60e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_f60f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f611, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_f617, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_f61a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_f61d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_f620, 3); add(edx, 0x6);                          /* add edx, 0x6 */
            ii(0x100d_f623, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f626, 5); calld(0x1013_bb7b, 0x5_c550);           /* call 0x1013bb7b */
            ii(0x100d_f62b, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_f632, 2); jmpd(0x100d_f63a, 0x6); goto l_0x100d_f63a; /* jmp 0x100df63a */
        l_0x100d_f634:
            ii(0x100d_f634, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_f637, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_f63a:
            ii(0x100d_f63a, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_f63e, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_f641, 2); if(jged(0x100d_f667, 0x24)) goto l_0x100d_f667; /* jge 0x100df667 */
            ii(0x100d_f643, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f646, 5); calld(0x1013_bc8c, 0x5_c641);           /* call 0x1013bc8c */
            ii(0x100d_f64b, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100d_f64f, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_f651, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100d_f654, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_f657, 3); add(ebx, 0x8);                          /* add ebx, 0x8 */
            ii(0x100d_f65a, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100d_f65c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f65e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f660, 5); calld(0x100c_b77c, -0x1_3ee9);          /* call 0x100cb77c */
            ii(0x100d_f665, 2); jmpd(0x100d_f634, -0x33); goto l_0x100d_f634; /* jmp 0x100df634 */
        l_0x100d_f667:
            ii(0x100d_f667, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100d_f66e, 2); jmpd(0x100d_f676, 0x6); goto l_0x100d_f676; /* jmp 0x100df676 */
        l_0x100d_f670:
            ii(0x100d_f670, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_f673, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100d_f676:
            ii(0x100d_f676, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_f67a, 3); cmp(eax, 0x5d);                         /* cmp eax, 0x5d */
            ii(0x100d_f67d, 2); if(jged(0x100d_f6a6, 0x27)) goto l_0x100d_f6a6; /* jge 0x100df6a6 */
            ii(0x100d_f67f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f682, 5); calld(0x1013_bc8c, 0x5_c605);           /* call 0x1013bc8c */
            ii(0x100d_f687, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x100d_f68b, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100d_f68d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100d_f690, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x100d_f693, 6); add(ebx, 0x17c);                        /* add ebx, 0x17c */
            ii(0x100d_f699, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100d_f69b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f69d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f69f, 5); calld(0x100c_b77c, -0x1_3f28);          /* call 0x100cb77c */
            ii(0x100d_f6a4, 2); jmpd(0x100d_f670, -0x36); goto l_0x100d_f670; /* jmp 0x100df670 */
        l_0x100d_f6a6:
            ii(0x100d_f6a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f6a9, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f6ae, 5); calld(0x1013_a6f4, 0x5_b041);           /* call 0x1013a6f4 */
            ii(0x100d_f6b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f6b6, 5); calld(0x1013_bc4f, 0x5_c594);           /* call 0x1013bc4f */
            ii(0x100d_f6bb, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
        l_0x100d_f6be:
            ii(0x100d_f6be, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x100d_f6c1, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x100d_f6c6, 2); if(jzd(0x100d_f6e1, 0x19)) goto l_0x100d_f6e1; /* jz 0x100df6e1 */
            ii(0x100d_f6c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_f6cb, 5); calld(0x1013_bc8c, 0x5_c5bc);           /* call 0x1013bc8c */
            ii(0x100d_f6d0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f6d2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_f6d5, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_f6da, 5); calld(0x100e_0cc0, 0x15e1);             /* call 0x100e0cc0 */
            ii(0x100d_f6df, 2); jmpd(0x100d_f6be, -0x23); goto l_0x100d_f6be; /* jmp 0x100df6be */
        l_0x100d_f6e1:
            ii(0x100d_f6e1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_f6e3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_f6e4, 1); popd(edi);                              /* pop edi */
            ii(0x100d_f6e5, 1); popd(esi);                              /* pop esi */
            ii(0x100d_f6e6, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_f6e7, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_f6e8, 1); retd();                                 /* ret */
        }
    }
}
