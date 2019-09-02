using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_37f9-f13c4a9a")]
        public void Method_1011_37f9()
        {
            ii(0x1011_37f9, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_37fe, 5); call(Definitions.sys_check_available_stack_size, 0x5_254f); /* call 0x10165d52 */
            ii(0x1011_3803, 1); push(ebx);                              /* push ebx */
            ii(0x1011_3804, 1); push(ecx);                              /* push ecx */
            ii(0x1011_3805, 1); push(edx);                              /* push edx */
            ii(0x1011_3806, 1); push(esi);                              /* push esi */
            ii(0x1011_3807, 1); push(edi);                              /* push edi */
            ii(0x1011_3808, 1); push(ebp);                              /* push ebp */
            ii(0x1011_3809, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_380b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_3811, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_3814, 4); mov(memb[ss, ebp - 8], 4);              /* mov byte [ebp-0x8], 0x4 */
        l_0x1011_3818:
            ii(0x1011_3818, 3); dec(memb[ss, ebp - 8]);                 /* dec byte [ebp-0x8] */
            ii(0x1011_381b, 4); cmp(memb[ss, ebp - 8], -1 /* 0xff */);  /* cmp byte [ebp-0x8], 0xff */
            ii(0x1011_381f, 2); if(jz(0x1011_3877, 0x56)) goto l_0x1011_3877; /* jz 0x10113877 */
            ii(0x1011_3821, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_3824, 2); add(al, 0xd);                           /* add al, 0xd */
            ii(0x1011_3826, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1011_3829, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_382b, 4); movsx(edx, memb[ss, ebp - 0xc]);        /* movsx edx, byte [ebp-0xc] */
            ii(0x1011_382f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_3832, 5); call(0x1011_285d, -0xfda);              /* call 0x1011285d */
            ii(0x1011_3837, 4); movsx(eax, memb[ss, ebp - 0xc]);        /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_383b, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_383e, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1011_3841, 4); cmp(memd[ds, eax + 0x16], 0);           /* cmp dword [eax+0x16], 0x0 */
            ii(0x1011_3845, 2); if(jz(0x1011_3875, 0x2e)) goto l_0x1011_3875; /* jz 0x10113875 */
            ii(0x1011_3847, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1011_384c, 4); movsx(eax, memb[ss, ebp - 0xc]);        /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3850, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_3853, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1011_3856, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_3859, 5); call(0x100c_f211, -0x4_464d);           /* call 0x100cf211 */
            ii(0x1011_385e, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1011_3863, 4); movsx(eax, memb[ss, ebp - 0xc]);        /* movsx eax, byte [ebp-0xc] */
            ii(0x1011_3867, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_386a, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1011_386d, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_3870, 5); call(0x100c_f363, -0x4_4512);           /* call 0x100cf363 */
        l_0x1011_3875:
            ii(0x1011_3875, 2); jmp(0x1011_3818, -0x5f); goto l_0x1011_3818; /* jmp 0x10113818 */
        l_0x1011_3877:
            ii(0x1011_3877, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_387a, 4); cmp(memd[ds, eax + 0x5a], 0);           /* cmp dword [eax+0x5a], 0x0 */
            ii(0x1011_387e, 2); if(jz(0x1011_3894, 0x14)) goto l_0x1011_3894; /* jz 0x10113894 */
            ii(0x1011_3880, 5); call(0x100d_51c4, -0x3_e6c1);           /* call 0x100d51c4 */
            ii(0x1011_3885, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_3887, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_3889, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_388c, 3); mov(eax, memd[ds, eax + 0x5a]);         /* mov eax, [eax+0x5a] */
            ii(0x1011_388f, 5); call(0x100c_fb06, -0x4_3d8e);           /* call 0x100cfb06 */
        l_0x1011_3894:
            ii(0x1011_3894, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_3897, 4); cmp(memd[ds, eax + 0x5e], 0);           /* cmp dword [eax+0x5e], 0x0 */
            ii(0x1011_389b, 2); if(jz(0x1011_38b1, 0x14)) goto l_0x1011_38b1; /* jz 0x101138b1 */
            ii(0x1011_389d, 5); call(0x100d_51c4, -0x3_e6de);           /* call 0x100d51c4 */
            ii(0x1011_38a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_38a4, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1011_38a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_38a9, 3); mov(eax, memd[ds, eax + 0x5e]);         /* mov eax, [eax+0x5e] */
            ii(0x1011_38ac, 5); call(0x100c_fb06, -0x4_3dab);           /* call 0x100cfb06 */
        l_0x1011_38b1:
            ii(0x1011_38b1, 4); mov(memb[ss, ebp - 8], 2);              /* mov byte [ebp-0x8], 0x2 */
            ii(0x1011_38b5, 2); jmp(0x1011_38bd, 6); goto l_0x1011_38bd; /* jmp 0x101138bd */
        l_0x1011_38b7:
            ii(0x1011_38b7, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_38ba, 3); inc(memb[ss, ebp - 8]);                 /* inc byte [ebp-0x8] */
        l_0x1011_38bd:
            ii(0x1011_38bd, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_38bf, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_38c2, 3); cmp(eax, 0xe);                          /* cmp eax, 0xe */
            ii(0x1011_38c5, 2); if(jge(0x1011_38e4, 0x1d)) goto l_0x1011_38e4; /* jge 0x101138e4 */
            ii(0x1011_38c7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_38ca, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1011_38cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_38ce, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1011_38d1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1011_38d4, 3); add(eax, memd[ss, ebp - 4]);            /* add eax, [ebp-0x4] */
            ii(0x1011_38d7, 6); mov(eax, memd[ds, eax + 0x59d]);        /* mov eax, [eax+0x59d] */
            ii(0x1011_38dd, 5); call(0x100d_7f6c, -0x3_b976);           /* call 0x100d7f6c */
            ii(0x1011_38e2, 2); jmp(0x1011_38b7, -0x2d); goto l_0x1011_38b7; /* jmp 0x101138b7 */
        l_0x1011_38e4:
            ii(0x1011_38e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_38e7, 7); mov(memb[ds, eax + 0x3b0], 0);          /* mov byte [eax+0x3b0], 0x0 */
            ii(0x1011_38ee, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_38f1, 7); mov(memb[ds, eax + 0x446], 0);          /* mov byte [eax+0x446], 0x0 */
            ii(0x1011_38f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_38fb, 9); mov(memw[ds, eax + 0x5d5], 0xffff);     /* mov word [eax+0x5d5], 0xffff */
            ii(0x1011_3904, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_3906, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_3907, 1); pop(edi);                               /* pop edi */
            ii(0x1011_3908, 1); pop(esi);                               /* pop esi */
            ii(0x1011_3909, 1); pop(edx);                               /* pop edx */
            ii(0x1011_390a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_390b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_390c, 1); ret();                                  /* ret */
        }
    }
}
