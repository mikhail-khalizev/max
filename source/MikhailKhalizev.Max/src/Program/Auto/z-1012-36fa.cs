using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbc82710-0073-482b-8fc4-8a2e1d8265ee")]
        public void Method_1012_36fa()
        {
            ii(0x1012_36fa, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1012_36ff, 5); calld(Definitions.sys_check_available_stack_size, 0x4_264e); /* call 0x10165d52 */
            ii(0x1012_3704, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_3705, 1); pushd(esi);                             /* push esi */
            ii(0x1012_3706, 1); pushd(edi);                             /* push edi */
            ii(0x1012_3707, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_3708, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_370a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_3710, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_3717, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_371a, 7); cmp(memd_a32[ds, eax + 0x84], 0);       /* cmp dword [eax+0x84], 0x0 */
            ii(0x1012_3721, 2); if(jnzd(0x1012_372f, 0xc)) goto l_0x1012_372f; /* jnz 0x1012372f */
            ii(0x1012_3723, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x1012_372a, 5); jmpd(0x1012_3846, 0x117); goto l_0x1012_3846; /* jmp 0x10123846 */
        l_0x1012_372f:
            ii(0x1012_372f, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3732, 6); mov(eax, memd_a32[ds, eax + 0x84]);     /* mov eax, [eax+0x84] */
            ii(0x1012_3738, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1012_373b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_373e, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_3741, 6); add(eax, memd_a32[ds, edx + 0x88]);     /* add eax, [edx+0x88] */
            ii(0x1012_3747, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_374a, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1012_3751:
            ii(0x1012_3751, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3754, 3); cmp(memb_a32[ds, eax], 0x5b);           /* cmp byte [eax], 0x5b */
            ii(0x1012_3757, 6); if(jnzd(0x1012_3817, 0xba)) goto l_0x1012_3817; /* jnz 0x10123817 */
            ii(0x1012_375d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3760, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_3763, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3766, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1012_3769, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_376c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1012_376f:
            ii(0x1012_376f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3772, 2); mov(dl, memb_a32[ds, eax]);             /* mov dl, [eax] */
            ii(0x1012_3774, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_3777, 2); cmp(dl, memb_a32[ds, eax]);             /* cmp dl, [eax] */
            ii(0x1012_3779, 2); if(jnzd(0x1012_3783, 0x8)) goto l_0x1012_3783; /* jnz 0x10123783 */
            ii(0x1012_377b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_377e, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1012_3781, 2); if(jbd(0x1012_3785, 0x2)) goto l_0x1012_3785; /* jb 0x10123785 */
        l_0x1012_3783:
            ii(0x1012_3783, 2); jmpd(0x1012_3799, 0x14); goto l_0x1012_3799; /* jmp 0x10123799 */
        l_0x1012_3785:
            ii(0x1012_3785, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_3788, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1012_378b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_378e, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1012_3791, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3794, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_3797, 2); jmpd(0x1012_376f, -0x2a); goto l_0x1012_376f; /* jmp 0x1012376f */
        l_0x1012_3799:
            ii(0x1012_3799, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_379c, 3); cmp(memb_a32[ds, eax], 0x5d);           /* cmp byte [eax], 0x5d */
            ii(0x1012_379f, 2); if(jnzd(0x1012_37af, 0xe)) goto l_0x1012_37af; /* jnz 0x101237af */
            ii(0x1012_37a1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_37a4, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_37a6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_37ab, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_37ad, 2); if(jzd(0x1012_37b1, 0x2)) goto l_0x1012_37b1; /* jz 0x101237b1 */
        l_0x1012_37af:
            ii(0x1012_37af, 2); jmpd(0x1012_3817, 0x66); goto l_0x1012_3817; /* jmp 0x10123817 */
        l_0x1012_37b1:
            ii(0x1012_37b1, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_37b8:
            ii(0x1012_37b8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37bb, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1012_37be, 2); if(jaed(0x1012_37cf, 0xf)) goto l_0x1012_37cf; /* jae 0x101237cf */
            ii(0x1012_37c0, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37c3, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_37c5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_37ca, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1012_37cd, 2); if(jnzd(0x1012_37d1, 0x2)) goto l_0x1012_37d1; /* jnz 0x101237d1 */
        l_0x1012_37cf:
            ii(0x1012_37cf, 2); jmpd(0x1012_37d9, 0x8); goto l_0x1012_37d9; /* jmp 0x101237d9 */
        l_0x1012_37d1:
            ii(0x1012_37d1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37d4, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1012_37d7, 2); jmpd(0x1012_37b8, -0x21); goto l_0x1012_37b8; /* jmp 0x101237b8 */
        l_0x1012_37d9:
            ii(0x1012_37d9, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37dc, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1012_37df, 2); if(jaed(0x1012_37e7, 0x6)) goto l_0x1012_37e7; /* jae 0x101237e7 */
            ii(0x1012_37e1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37e4, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1012_37e7:
            ii(0x1012_37e7, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37ea, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_37ed, 6); mov(memd_a32[ds, edx + 0xa8], eax);     /* mov [edx+0xa8], eax */
            ii(0x1012_37f3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_37f6, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_37f9, 6); mov(memd_a32[ds, edx + 0x90], eax);     /* mov [edx+0x90], eax */
            ii(0x1012_37ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3802, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_3805, 6); mov(memd_a32[ds, edx + 0x94], eax);     /* mov [edx+0x94], eax */
            ii(0x1012_380b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1012_380e, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_3811, 6); mov(memd_a32[ds, edx + 0x98], eax);     /* mov [edx+0x98], eax */
        l_0x1012_3817:
            ii(0x1012_3817, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_381a, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1012_381d, 2); if(jaed(0x1012_3825, 0x6)) goto l_0x1012_3825; /* jae 0x10123825 */
            ii(0x1012_381f, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3822, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1012_3825:
            ii(0x1012_3825, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3828, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1012_382b, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1012_382f, 2); if(jnzd(0x1012_3839, 0x8)) goto l_0x1012_3839; /* jnz 0x10123839 */
            ii(0x1012_3831, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1012_3834, 3); cmp(eax, memd_a32[ss, ebp - 0xc]);      /* cmp eax, [ebp-0xc] */
            ii(0x1012_3837, 2); if(jbd(0x1012_383b, 0x2)) goto l_0x1012_383b; /* jb 0x1012383b */
        l_0x1012_3839:
            ii(0x1012_3839, 2); jmpd(0x1012_3840, 0x5); goto l_0x1012_3840; /* jmp 0x10123840 */
        l_0x1012_383b:
            ii(0x1012_383b, 5); jmpd(0x1012_3751, -0xef); goto l_0x1012_3751; /* jmp 0x10123751 */
        l_0x1012_3840:
            ii(0x1012_3840, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3843, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x1012_3846:
            ii(0x1012_3846, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1012_3849, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_384b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_384c, 1); popd(edi);                              /* pop edi */
            ii(0x1012_384d, 1); popd(esi);                              /* pop esi */
            ii(0x1012_384e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_384f, 1); retd(); return;                         /* ret */
        }
    }
}
