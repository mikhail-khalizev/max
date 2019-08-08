using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4a153fb2-59dc-4e4e-ae97-e2f9e6213d39")]
        public void Method_1010_4fac()
        {
            ii(0x1010_4fac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_4fb1, 5); calld(Definitions.sys_check_available_stack_size, 0x6_0d9c); /* call 0x10165d52 */
            ii(0x1010_4fb6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_4fb7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_4fb8, 1); pushd(edx);                             /* push edx */
            ii(0x1010_4fb9, 1); pushd(esi);                             /* push esi */
            ii(0x1010_4fba, 1); pushd(edi);                             /* push edi */
            ii(0x1010_4fbb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_4fbc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_4fbe, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_4fc4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
        l_0x1010_4fc7:
            ii(0x1010_4fc7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4fca, 5); calld(0x1010_4f1b, -0xb4);              /* call 0x10104f1b */
            ii(0x1010_4fcf, 2); test(al, al);                           /* test al, al */
            ii(0x1010_4fd1, 2); if(jnzd(0x1010_4fd9, 0x6)) goto l_0x1010_4fd9; /* jnz 0x10104fd9 */
            ii(0x1010_4fd3, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1010_4fd7, 2); jmpd(0x1010_5005, 0x2c); goto l_0x1010_5005; /* jmp 0x10105005 */
        l_0x1010_4fd9:
            ii(0x1010_4fd9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4fdc, 6); mov(edx, memd_a32[ds, eax + 0x454]);    /* mov edx, [eax+0x454] */
            ii(0x1010_4fe2, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1010_4fe5, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1010_4fe8, 6); mov(edx, memd_a32[ds, edx + 0x101b_8af0]); /* mov edx, [edx+0x101b8af0] */
            ii(0x1010_4fee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_4ff1, 3); add(eax, 0x6f);                         /* add eax, 0x6f */
            ii(0x1010_4ff4, 5); calld(Definitions.sys_strstr, 0x7_4017); /* call 0x10179010 */
            ii(0x1010_4ff9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_4ffb, 2); if(jzd(0x1010_5003, 0x6)) goto l_0x1010_5003; /* jz 0x10105003 */
            ii(0x1010_4ffd, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_5001, 2); jmpd(0x1010_5005, 0x2); goto l_0x1010_5005; /* jmp 0x10105005 */
        l_0x1010_5003:
            ii(0x1010_5003, 2); jmpd(0x1010_4fc7, -0x3e); goto l_0x1010_4fc7; /* jmp 0x10104fc7 */
        l_0x1010_5005:
            ii(0x1010_5005, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1010_5008, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_500a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_500b, 1); popd(edi);                              /* pop edi */
            ii(0x1010_500c, 1); popd(esi);                              /* pop esi */
            ii(0x1010_500d, 1); popd(edx);                              /* pop edx */
            ii(0x1010_500e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_500f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_5010, 1); retd(); return;                         /* ret */
        }
    }
}
