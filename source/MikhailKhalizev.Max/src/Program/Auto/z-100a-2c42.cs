using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9b7e2f1e-4e28-48f0-98ea-dde1af82b3d0")]
        public void Method_100a_2c42()
        {
            ii(0x100a_2c42, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_2c47, 5); calld(Definitions.sys_check_available_stack_size, 0xc_3106); /* call 0x10165d52 */
            ii(0x100a_2c4c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2c4d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2c4e, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2c4f, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2c50, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2c51, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2c53, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_2c59, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_2c5c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_2c5f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2c62, 5); calld(0x1007_623c, -0x2_ca2b);          /* call 0x1007623c */
            ii(0x100a_2c67, 4); cmp(memb_a32[ds, eax + 0x16], 0);       /* cmp byte [eax+0x16], 0x0 */
            ii(0x100a_2c6b, 2); if(jzd(0x100a_2c7c, 0xf)) goto l_0x100a_2c7c; /* jz 0x100a2c7c */
            ii(0x100a_2c6d, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100a_2c72, 5); calld(0x1007_5fdc, -0x2_cc9b);          /* call 0x10075fdc */
            ii(0x100a_2c77, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_2c7a, 2); if(jged(0x100a_2c7e, 0x2)) goto l_0x100a_2c7e; /* jge 0x100a2c7e */
        l_0x100a_2c7c:
            ii(0x100a_2c7c, 2); jmpd(0x100a_2c99, 0x1b); goto l_0x100a_2c99; /* jmp 0x100a2c99 */
        l_0x100a_2c7e:
            ii(0x100a_2c7e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2c81, 3); mov(al, memb_a32[ds, eax + 0x50]);      /* mov al, [eax+0x50] */
            ii(0x100a_2c84, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_2c89, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_2c8b, 2); if(jnzd(0x100a_2c93, 0x6)) goto l_0x100a_2c93; /* jnz 0x100a2c93 */
            ii(0x100a_2c8d, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100a_2c91, 2); jmpd(0x100a_2cac, 0x19); goto l_0x100a_2cac; /* jmp 0x100a2cac */
        l_0x100a_2c93:
            ii(0x100a_2c93, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_2c97, 2); jmpd(0x100a_2cac, 0x13); goto l_0x100a_2cac; /* jmp 0x100a2cac */
        l_0x100a_2c99:
            ii(0x100a_2c99, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2c9c, 4); cmp(memb_a32[ds, eax + 0x54], 0);       /* cmp byte [eax+0x54], 0x0 */
            ii(0x100a_2ca0, 2); if(jzd(0x100a_2ca8, 0x6)) goto l_0x100a_2ca8; /* jz 0x100a2ca8 */
            ii(0x100a_2ca2, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100a_2ca6, 2); jmpd(0x100a_2cac, 0x4); goto l_0x100a_2cac; /* jmp 0x100a2cac */
        l_0x100a_2ca8:
            ii(0x100a_2ca8, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
        l_0x100a_2cac:
            ii(0x100a_2cac, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_2caf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2cb1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2cb2, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2cb3, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2cb4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2cb5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2cb6, 1); retd(); return;                         /* ret */
        }
    }
}
