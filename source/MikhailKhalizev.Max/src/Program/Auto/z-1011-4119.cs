using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_4119-9fb661d")]
        public void Method_1011_4119()
        {
            ii(0x1011_4119, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_411e, 5); calld(Definitions.sys_check_available_stack_size, 0x5_1c2f); /* call 0x10165d52 */
            ii(0x1011_4123, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_4124, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_4125, 1); pushd(esi);                             /* push esi */
            ii(0x1011_4126, 1); pushd(edi);                             /* push edi */
            ii(0x1011_4127, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_4128, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_412a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_4130, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_4133, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_4136, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1011_4139, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1011_413c, 3); mov(memb_a32[ds, edx + 0x12], al);      /* mov [edx+0x12], al */
            ii(0x1011_413f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_4142, 6); mov(al, memb_a32[ds, eax + 0x51f]);     /* mov al, [eax+0x51f] */
            ii(0x1011_4148, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_414d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_414f, 2); if(jnzd(0x1011_4177, 0x26)) goto l_0x1011_4177; /* jnz 0x10114177 */
            ii(0x1011_4151, 7); mov(memd_a32[ss, ebp - 0xc], 0x4);      /* mov dword [ebp-0xc], 0x4 */
        l_0x1011_4158:
            ii(0x1011_4158, 3); dec(memd_a32[ss, ebp - 0xc]);           /* dec dword [ebp-0xc] */
            ii(0x1011_415b, 5); cmp(memw_a32[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1011_4160, 2); if(jzd(0x1011_4177, 0x15)) goto l_0x1011_4177; /* jz 0x10114177 */
            ii(0x1011_4162, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1011_4166, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_4168, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x1011_416b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_416e, 7); mov(memw_a32[ds, edx + 0x4e4], ax);     /* mov [edx+0x4e4], ax */
            ii(0x1011_4175, 2); jmpd(0x1011_4158, -0x1f); goto l_0x1011_4158; /* jmp 0x10114158 */
        l_0x1011_4177:
            ii(0x1011_4177, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_4179, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_417a, 1); popd(edi);                              /* pop edi */
            ii(0x1011_417b, 1); popd(esi);                              /* pop esi */
            ii(0x1011_417c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_417d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_417e, 1); retd();                                 /* ret */
        }
    }
}
