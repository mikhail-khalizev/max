using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4882-3fd830a")]
        public void Method_100e_4882()
        {
            ii(0x100e_4882, 5); pushd(0x40);                            /* push 0x40 */
            ii(0x100e_4887, 5); calld(Definitions.sys_check_available_stack_size, 0x8_14c6); /* call 0x10165d52 */
            ii(0x100e_488c, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_488d, 1); pushd(esi);                             /* push esi */
            ii(0x100e_488e, 1); pushd(edi);                             /* push edi */
            ii(0x100e_488f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_4890, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_4892, 6); sub(esp, 0x2c);                         /* sub esp, 0x2c */
            ii(0x100e_4898, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_489b, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_489e, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100e_48a1, 5); mov(ebx, 0x1c);                         /* mov ebx, 0x1c */
            ii(0x100e_48a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_48a8, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100e_48ab, 5); calld(Definitions.sys_memset, 0x8_1530); /* call 0x10165de0 */
            ii(0x100e_48b0, 6); mov(memw_a32[ss, ebp - 0x2c], 0);       /* mov word [ebp-0x2c], 0x0 */
            ii(0x100e_48b6, 6); mov(memw_a32[ss, ebp - 0x24], 0x1);     /* mov word [ebp-0x24], 0x1 */
            ii(0x100e_48bc, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x100e_48bf, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100e_48c2, 5); mov(eax, 0x31);                         /* mov eax, 0x31 */
            ii(0x100e_48c7, 5); calld(/* sys */ 0x1016_c606, 0x8_7d3a); /* call 0x1016c606 */
            ii(0x100e_48cc, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100e_48d0, 2); if(jzd(0x100e_48db, 0x9)) goto l_0x100e_48db; /* jz 0x100e48db */
            ii(0x100e_48d2, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_48d9, 2); jmpd(0x100e_492b, 0x50); goto l_0x100e_492b; /* jmp 0x100e492b */
        l_0x100e_48db:
            ii(0x100e_48db, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_48de, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100e_48e1, 3); mov(memw_a32[ds, edx], ax);             /* mov [edx], ax */
            ii(0x100e_48e4, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100e_48e7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_48ea, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_48ed, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100e_48f2, 5); calld(0x100e_4780, -0x177);             /* call 0x100e4780 */
            ii(0x100e_48f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_48f9, 2); if(jnzd(0x100e_4904, 0x9)) goto l_0x100e_4904; /* jnz 0x100e4904 */
            ii(0x100e_48fb, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_4902, 2); jmpd(0x100e_492b, 0x27); goto l_0x100e_492b; /* jmp 0x100e492b */
        l_0x100e_4904:
            ii(0x100e_4904, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100e_4907, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_490a, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100e_490d, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100e_4912, 5); calld(0x100e_4801, -0x116);             /* call 0x100e4801 */
            ii(0x100e_4917, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_4919, 2); if(jnzd(0x100e_4924, 0x9)) goto l_0x100e_4924; /* jnz 0x100e4924 */
            ii(0x100e_491b, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100e_4922, 2); jmpd(0x100e_492b, 0x7); goto l_0x100e_492b; /* jmp 0x100e492b */
        l_0x100e_4924:
            ii(0x100e_4924, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x100e_492b:
            ii(0x100e_492b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_492e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_4930, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_4931, 1); popd(edi);                              /* pop edi */
            ii(0x100e_4932, 1); popd(esi);                              /* pop esi */
            ii(0x100e_4933, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_4934, 1); retd();                                 /* ret */
        }
    }
}
