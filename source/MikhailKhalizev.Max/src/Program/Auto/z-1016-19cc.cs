using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("662943e4-de06-44dd-92b2-6eaadd5d3f06")]
        public void Method_1016_19cc()
        {
            ii(0x1016_19cc, 5); pushd(0x9c);                            /* push 0x9c */
            ii(0x1016_19d1, 5); calld(Definitions.sys_check_available_stack_size, 0x437c); /* call 0x10165d52 */
            ii(0x1016_19d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_19d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_19d8, 1); pushd(edx);                             /* push edx */
            ii(0x1016_19d9, 1); pushd(esi);                             /* push esi */
            ii(0x1016_19da, 1); pushd(edi);                             /* push edi */
            ii(0x1016_19db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_19dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_19de, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x1016_19e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_19e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_19ea, 4); test(memb_a32[ds, eax + 0x15], 0x8);    /* test byte [eax+0x15], 0x8 */
            ii(0x1016_19ee, 2); if(jzd(0x1016_19f9, 0x9)) goto l_0x1016_19f9; /* jz 0x101619f9 */
            ii(0x1016_19f0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_19f3, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1016_19f7, 2); if(jnzd(0x1016_19fb, 0x2)) goto l_0x1016_19fb; /* jnz 0x101619fb */
        l_0x1016_19f9:
            ii(0x1016_19f9, 2); jmpd(0x1016_1a09, 0xe); goto l_0x1016_1a09; /* jmp 0x10161a09 */
        l_0x1016_19fb:
            ii(0x1016_19fb, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_1a00, 5); calld(0x1007_5fdc, -0xeba29);           /* call 0x10075fdc */
            ii(0x1016_1a05, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1a07, 2); if(jnzd(0x1016_1a0b, 0x2)) goto l_0x1016_1a0b; /* jnz 0x10161a0b */
        l_0x1016_1a09:
            ii(0x1016_1a09, 2); jmpd(0x1016_1a13, 0x8); goto l_0x1016_1a13; /* jmp 0x10161a13 */
        l_0x1016_1a0b:
            ii(0x1016_1a0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a0e, 5); calld(0x1015_4853, -0xd1c0);            /* call 0x10154853 */
        l_0x1016_1a13:
            ii(0x1016_1a13, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a16, 4); test(memb_a32[ds, eax + 0x12], 0x20);   /* test byte [eax+0x12], 0x20 */
            ii(0x1016_1a1a, 2); if(jnzd(0x1016_1a25, 0x9)) goto l_0x1016_1a25; /* jnz 0x10161a25 */
            ii(0x1016_1a1c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a1f, 4); cmp(memb_a32[ds, eax + 0x3e], 0xe);     /* cmp byte [eax+0x3e], 0xe */
            ii(0x1016_1a23, 2); if(jnzd(0x1016_1a33, 0xe)) goto l_0x1016_1a33; /* jnz 0x10161a33 */
        l_0x1016_1a25:
            ii(0x1016_1a25, 7); mov(memb_a32[ds, 0x101c_9447], 0x1);    /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1a2c, 7); mov(memb_a32[ds, 0x101c_9448], 0x1);    /* mov byte [0x101c9448], 0x1 */
        l_0x1016_1a33:
            ii(0x1016_1a33, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1a36, 3); mov(al, memb_a32[ds, eax + 0x3d]);      /* mov al, [eax+0x3d] */
            ii(0x1016_1a39, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
            ii(0x1016_1a3c, 5); jmpd_func(0x1016_2988, 0xf47); return;  /* jmp 0x10162988 */
        }
    }
}
