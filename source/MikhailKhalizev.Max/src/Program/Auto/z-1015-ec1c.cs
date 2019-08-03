using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("517b0b73-f0a6-43b4-970d-cc46054e11a3")]
        public void Method_1015_ec1c()
        {
            ii(0x1015_ec1c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_ec21, 5); calld(Definitions.sys_check_available_stack_size, 0x712c); /* call 0x10165d52 */
            ii(0x1015_ec26, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_ec27, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_ec28, 1); pushd(edx);                             /* push edx */
            ii(0x1015_ec29, 1); pushd(esi);                             /* push esi */
            ii(0x1015_ec2a, 1); pushd(edi);                             /* push edi */
            ii(0x1015_ec2b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_ec2c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_ec2e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_ec34, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_ec37, 5); cmp(memw_a32[ss, ebp - 0x4], 0x17);     /* cmp word [ebp-0x4], 0x17 */
            ii(0x1015_ec3c, 2); if(jzd(0x1015_ec45, 0x7)) goto l_0x1015_ec45; /* jz 0x1015ec45 */
            ii(0x1015_ec3e, 5); cmp(memw_a32[ss, ebp - 0x4], 0x18);     /* cmp word [ebp-0x4], 0x18 */
            ii(0x1015_ec43, 2); if(jnzd(0x1015_ec47, 0x2)) goto l_0x1015_ec47; /* jnz 0x1015ec47 */
        l_0x1015_ec45:
            ii(0x1015_ec45, 2); jmpd(0x1015_ec4e, 0x7); goto l_0x1015_ec4e; /* jmp 0x1015ec4e */
        l_0x1015_ec47:
            ii(0x1015_ec47, 5); cmp(memw_a32[ss, ebp - 0x4], 0x19);     /* cmp word [ebp-0x4], 0x19 */
            ii(0x1015_ec4c, 2); if(jnzd(0x1015_ec50, 0x2)) goto l_0x1015_ec50; /* jnz 0x1015ec50 */
        l_0x1015_ec4e:
            ii(0x1015_ec4e, 2); jmpd(0x1015_ec57, 0x7); goto l_0x1015_ec57; /* jmp 0x1015ec57 */
        l_0x1015_ec50:
            ii(0x1015_ec50, 5); cmp(memw_a32[ss, ebp - 0x4], 0x1b);     /* cmp word [ebp-0x4], 0x1b */
            ii(0x1015_ec55, 2); if(jnzd(0x1015_ec5d, 0x6)) goto l_0x1015_ec5d; /* jnz 0x1015ec5d */
        l_0x1015_ec57:
            ii(0x1015_ec57, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1015_ec5b, 2); jmpd(0x1015_ec61, 0x4); goto l_0x1015_ec61; /* jmp 0x1015ec61 */
        l_0x1015_ec5d:
            ii(0x1015_ec5d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1015_ec61:
            ii(0x1015_ec61, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_ec64, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1015_ec67, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1015_ec6a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_ec6c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_ec6d, 1); popd(edi);                              /* pop edi */
            ii(0x1015_ec6e, 1); popd(esi);                              /* pop esi */
            ii(0x1015_ec6f, 1); popd(edx);                              /* pop edx */
            ii(0x1015_ec70, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_ec71, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_ec72, 1); retd(); return;                         /* ret */
        }
    }
}
