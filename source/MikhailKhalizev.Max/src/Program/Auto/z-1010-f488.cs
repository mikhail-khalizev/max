using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f488-c41da057")]
        public void Method_1010_f488()
        {
            ii(0x1010_f488, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1010_f48d, 5); calld(Definitions.sys_check_available_stack_size, 0x5_68c0); /* call 0x10165d52 */
            ii(0x1010_f492, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_f493, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_f494, 1); pushd(edx);                             /* push edx */
            ii(0x1010_f495, 1); pushd(esi);                             /* push esi */
            ii(0x1010_f496, 1); pushd(edi);                             /* push edi */
            ii(0x1010_f497, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_f498, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f49a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_f4a0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_f4a3, 5); calld(0x100d_4e6c, -0x3_a63c);          /* call 0x100d4e6c */
            ii(0x1010_f4a8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f4ad, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_f4b0, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_f4b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_f4ba, 3); mov(al, memb_a32[ds, eax + 0x14]);      /* mov al, [eax+0x14] */
            ii(0x1010_f4bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1010_f4c2, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1010_f4c5, 2); if(jnzd(0x1010_f4cd, 0x6)) goto l_0x1010_f4cd; /* jnz 0x1010f4cd */
            ii(0x1010_f4c7, 4); mov(memb_a32[ss, ebp - 0x8], 0x14);     /* mov byte [ebp-0x8], 0x14 */
            ii(0x1010_f4cb, 2); jmpd(0x1010_f4d1, 0x4); goto l_0x1010_f4d1; /* jmp 0x1010f4d1 */
        l_0x1010_f4cd:
            ii(0x1010_f4cd, 4); mov(memb_a32[ss, ebp - 0x8], 0x15);     /* mov byte [ebp-0x8], 0x15 */
        l_0x1010_f4d1:
            ii(0x1010_f4d1, 3); mov(eax, memd_a32[ss, ebp - 0xb]);      /* mov eax, [ebp-0xb] */
            ii(0x1010_f4d4, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1010_f4d7, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1010_f4da, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_f4dd, 5); calld(0x1010_5b00, -0x99e2);            /* call 0x10105b00 */
            ii(0x1010_f4e2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f4e4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_f4e5, 1); popd(edi);                              /* pop edi */
            ii(0x1010_f4e6, 1); popd(esi);                              /* pop esi */
            ii(0x1010_f4e7, 1); popd(edx);                              /* pop edx */
            ii(0x1010_f4e8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_f4e9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_f4ea, 1); retd();                                 /* ret */
        }
    }
}
