using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c10ea5e1-56f9-4b8a-b2d3-5b275520747f")]
        public void Method_1007_78a5()
        {
            ii(0x1007_78a5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_78aa, 5); calld(Definitions.sys_check_available_stack_size, 0xe_e4a3); /* call 0x10165d52 */
            ii(0x1007_78af, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_78b0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_78b1, 1); pushd(esi);                             /* push esi */
            ii(0x1007_78b2, 1); pushd(edi);                             /* push edi */
            ii(0x1007_78b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_78b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_78b6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_78bc, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_78bf, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_78c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_78c5, 5); cmp(memw_a32[ds, eax + 0x8], 0x42);     /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_78ca, 2); if(jnzd(0x1007_78d5, 0x9)) goto l_0x1007_78d5; /* jnz 0x100778d5 */
            ii(0x1007_78cc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_78cf, 4); test(memb_a32[ds, eax + 0x14], 0x20);   /* test byte [eax+0x14], 0x20 */
            ii(0x1007_78d3, 2); if(jnzd(0x1007_78d7, 0x2)) goto l_0x1007_78d7; /* jnz 0x100778d7 */
        l_0x1007_78d5:
            ii(0x1007_78d5, 2); jmpd(0x1007_78e0, 0x9); goto l_0x1007_78e0; /* jmp 0x100778e0 */
        l_0x1007_78d7:
            ii(0x1007_78d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_78da, 4); test(memb_a32[ds, eax + 0x14], 0x1);    /* test byte [eax+0x14], 0x1 */
            ii(0x1007_78de, 2); if(jzd(0x1007_78e2, 0x2)) goto l_0x1007_78e2; /* jz 0x100778e2 */
        l_0x1007_78e0:
            ii(0x1007_78e0, 2); jmpd(0x1007_78f6, 0x14); goto l_0x1007_78f6; /* jmp 0x100778f6 */
        l_0x1007_78e2:
            ii(0x1007_78e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_78e5, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_78e9, 2); if(jnzd(0x1007_78f4, 0x9)) goto l_0x1007_78f4; /* jnz 0x100778f4 */
            ii(0x1007_78eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_78ee, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_78f2, 2); if(jnzd(0x1007_78f6, 0x2)) goto l_0x1007_78f6; /* jnz 0x100778f6 */
        l_0x1007_78f4:
            ii(0x1007_78f4, 2); jmpd(0x1007_78f8, 0x2); goto l_0x1007_78f8; /* jmp 0x100778f8 */
        l_0x1007_78f6:
            ii(0x1007_78f6, 2); jmpd(0x1007_78fe, 0x6); goto l_0x1007_78fe; /* jmp 0x100778fe */
        l_0x1007_78f8:
            ii(0x1007_78f8, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1007_78fc, 2); jmpd(0x1007_7902, 0x4); goto l_0x1007_7902; /* jmp 0x10077902 */
        l_0x1007_78fe:
            ii(0x1007_78fe, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x1007_7902:
            ii(0x1007_7902, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1007_7905, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1007_7908, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1007_790b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_790d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_790e, 1); popd(edi);                              /* pop edi */
            ii(0x1007_790f, 1); popd(esi);                              /* pop esi */
            ii(0x1007_7910, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_7911, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_7912, 1); retd(); return;                         /* ret */
        }
    }
}
