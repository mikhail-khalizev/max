using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_96ae-f2912e5a")]
        public void Method_1012_96ae()
        {
            ii(0x1012_96ae, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1012_96b3, 5); calld(Definitions.sys_check_available_stack_size, 0x3_c69a); /* call 0x10165d52 */
            ii(0x1012_96b8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_96b9, 1); pushd(esi);                             /* push esi */
            ii(0x1012_96ba, 1); pushd(edi);                             /* push edi */
            ii(0x1012_96bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_96bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_96be, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1012_96c4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_96c7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_96ca, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1012_96cd, 5); mov(edx, 0x225);                        /* mov edx, 0x225 */
            ii(0x1012_96d2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_96d5, 5); calld(Definitions.sys_strlen, 0x4_87ed); /* call 0x10171ec7 */
            ii(0x1012_96da, 5); calld(Definitions.my_min, -0x9_ff5b);   /* call 0x10089784 */
            ii(0x1012_96df, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_96e2, 5); cmp(memw_a32[ss, ebp - 0x10], 0);       /* cmp word [ebp-0x10], 0x0 */
            ii(0x1012_96e7, 2); if(jzd(0x1012_96f2, 0x9)) goto l_0x1012_96f2; /* jz 0x101296f2 */
            ii(0x1012_96e9, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
            ii(0x1012_96f0, 2); if(jnzd(0x1012_96f4, 0x2)) goto l_0x1012_96f4; /* jnz 0x101296f4 */
        l_0x1012_96f2:
            ii(0x1012_96f2, 2); jmpd(0x1012_974c, 0x58); goto l_0x1012_974c; /* jmp 0x1012974c */
        l_0x1012_96f4:
            ii(0x1012_96f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_96f7, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1012_96fa, 1); cwde();                                 /* cwde */
            ii(0x1012_96fb, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1012_96fe, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1012_9701, 7); mov(memb_a32[ds, 0x101c_5c1c], 0x12);   /* mov byte [0x101c5c1c], 0x12 */
            ii(0x1012_9708, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_970b, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_9711, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_9714, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_971a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_971d, 5); mov(eax, 0x101c_5c21);                  /* mov eax, 0x101c5c21 */
            ii(0x1012_9722, 5); calld(Definitions.sys_strcpy, 0x3_c7a8); /* call 0x10165ecf */
            ii(0x1012_9727, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_972c, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x1012_972f, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_9734, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1012_9736, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1012_9739, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_973e, 5); calld(0x1010_6281, -0x2_34c2);          /* call 0x10106281 */
            ii(0x1012_9743, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_9747, 5); calld(0x1012_5be9, -0x3b63);            /* call 0x10125be9 */
        l_0x1012_974c:
            ii(0x1012_974c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_974e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_974f, 1); popd(edi);                              /* pop edi */
            ii(0x1012_9750, 1); popd(esi);                              /* pop esi */
            ii(0x1012_9751, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_9752, 1); retd();                                 /* ret */
        }
    }
}
