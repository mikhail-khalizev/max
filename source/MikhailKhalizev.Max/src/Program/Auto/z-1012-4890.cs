using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e4b7647-58c3-49b8-a444-318f23f2f1e7")]
        public void Method_1012_4890()
        {
            ii(0x1012_4890, 5); pushd(0x260);                           /* push 0x260 */
            ii(0x1012_4895, 5); calld(Definitions.sys_check_available_stack_size, 0x4_14b8); /* call 0x10165d52 */
            ii(0x1012_489a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_489b, 1); pushd(esi);                             /* push esi */
            ii(0x1012_489c, 1); pushd(edi);                             /* push edi */
            ii(0x1012_489d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_489e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_48a0, 6); sub(esp, 0x248);                        /* sub esp, 0x248 */
            ii(0x1012_48a6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_48a9, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_48ac, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1012_48af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_48b1, 5); mov(al, memb_a32[ds, 0x101c_59bb]);     /* mov al, [0x101c59bb] */
            ii(0x1012_48b6, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1012_48bb, 2); if(jnzd(0x1012_4904, 0x47)) goto l_0x1012_4904; /* jnz 0x10124904 */
        l_0x1012_48bd:
            ii(0x1012_48bd, 6); mov(edx, memd_a32[ds, 0x101c_5878]);    /* mov edx, [0x101c5878] */
            ii(0x1012_48c3, 5); mov(eax, memd_a32[ds, 0x101c_587c]);    /* mov eax, [0x101c587c] */
            ii(0x1012_48c8, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1012_48ca, 2); cmp(edx, memd_a32[ds, eax]);            /* cmp edx, [eax] */
            ii(0x1012_48cc, 2); if(jzd(0x1012_48da, 0xc)) goto l_0x1012_48da; /* jz 0x101248da */
            ii(0x1012_48ce, 5); mov(eax, memd_a32[ds, 0x101c_5878]);    /* mov eax, [0x101c5878] */
            ii(0x1012_48d3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1012_48d5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_48d8, 2); jmpd(0x1012_48bd, -0x1d); goto l_0x1012_48bd; /* jmp 0x101248bd */
        l_0x1012_48da:
            ii(0x1012_48da, 1); cli();                                  /* cli */
            ii(0x1012_48db, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_48dd, 5); mov(al, memb_a32[ds, 0x101c_59ba]);     /* mov al, [0x101c59ba] */
            ii(0x1012_48e2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_48e5, 6); mov(edx, memd_a32[ds, 0x101c_587c]);    /* mov edx, [0x101c587c] */
            ii(0x1012_48eb, 6); mov(eax, memd_a32[ds, eax + 0x101c_5880]); /* mov eax, [eax+0x101c5880] */
            ii(0x1012_48f1, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1012_48f3, 5); mov(eax, memd_a32[ds, 0x101c_587c]);    /* mov eax, [0x101c587c] */
            ii(0x1012_48f8, 6); mov(edx, memd_a32[ds, 0x101c_5878]);    /* mov edx, [0x101c5878] */
            ii(0x1012_48fe, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1012_4900, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1012_4902, 1); sti();                                  /* sti */
            ii(0x1012_4903, 1); cld();                                  /* cld */
        l_0x1012_4904:
            ii(0x1012_4904, 5); mov(eax, memd_a32[ds, 0x101c_5878]);    /* mov eax, [0x101c5878] */
            ii(0x1012_4909, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1012_490b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_490e, 9); mov(memw_a32[ds, 0x101c_59b4], 0);      /* mov word [0x101c59b4], 0x0 */
            ii(0x1012_4917, 6); lea(eax, ebp - 0x23d);                  /* lea eax, [ebp-0x23d] */
            ii(0x1012_491d, 6); mov(memd_a32[ss, ebp - 0x244], eax);    /* mov [ebp-0x244], eax */
            ii(0x1012_4923, 10); mov(memd_a32[ss, ebp - 0x248], 0);     /* mov dword [ebp-0x248], 0x0 */
            ii(0x1012_492d, 2); jmpd(0x1012_493b, 0xc); goto l_0x1012_493b; /* jmp 0x1012493b */
        l_0x1012_492f:
            ii(0x1012_492f, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4935, 6); inc(memd_a32[ss, ebp - 0x248]);         /* inc dword [ebp-0x248] */
        l_0x1012_493b:
            ii(0x1012_493b, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4941, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1012_4944, 2); if(jged(0x1012_496d, 0x27)) goto l_0x1012_496d; /* jge 0x1012496d */
            ii(0x1012_4946, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_4949, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_494b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_4950, 5); calld(0x100c_dd8f, -0x5_6bc6);          /* call 0x100cdd8f */
            ii(0x1012_4955, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_4958, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1012_495b, 6); mov(edx, memd_a32[ss, ebp - 0x244]);    /* mov edx, [ebp-0x244] */
            ii(0x1012_4961, 6); inc(memd_a32[ss, ebp - 0x244]);         /* inc dword [ebp-0x244] */
            ii(0x1012_4967, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1012_4969, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1012_496b, 2); jmpd(0x1012_492f, -0x3e); goto l_0x1012_492f; /* jmp 0x1012492f */
        l_0x1012_496d:
            ii(0x1012_496d, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_4971, 6); if(jzd(0x1012_4a10, 0x99)) goto l_0x1012_4a10; /* jz 0x10124a10 */
            ii(0x1012_4977, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_4979, 6); mov(dl, memb_a32[ds, 0x101c_59ba]);     /* mov dl, [0x101c59ba] */
            ii(0x1012_497f, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_4982, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_4985, 6); mov(memd_a32[ds, edx + 0x101c_5880], eax); /* mov [edx+0x101c5880], eax */
            ii(0x1012_498b, 5); mov(al, memb_a32[ds, 0x101c_59ba]);     /* mov al, [0x101c59ba] */
            ii(0x1012_4990, 6); mov(memb_a32[ss, ebp - 0x240], al);     /* mov [ebp-0x240], al */
            ii(0x1012_4996, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_4998, 5); calld(0x100c_dd8f, -0x5_6c0e);          /* call 0x100cdd8f */
            ii(0x1012_499d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_49a2, 5); calld(0x100c_dd8f, -0x5_6c18);          /* call 0x100cdd8f */
            ii(0x1012_49a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_49aa, 7); mov(memw_a32[ss, ebp - 0x23f], ax);     /* mov [ebp-0x23f], ax */
            ii(0x1012_49b1, 6); mov(dl, memb_a32[ds, 0x101c_59b4]);     /* mov dl, [0x101c59b4] */
            ii(0x1012_49b7, 6); mov(eax, memd_a32[ss, ebp - 0x244]);    /* mov eax, [ebp-0x244] */
            ii(0x1012_49bd, 6); inc(memd_a32[ss, ebp - 0x244]);         /* inc dword [ebp-0x244] */
            ii(0x1012_49c3, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1012_49c5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_49c7, 6); mov(ax, memw_a32[ds, 0x101c_59b4]);     /* mov ax, [0x101c59b4] */
            ii(0x1012_49cd, 3); sar(eax, 0x8);                          /* sar eax, 0x8 */
            ii(0x1012_49d0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_49d5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_49d7, 6); mov(eax, memd_a32[ss, ebp - 0x244]);    /* mov eax, [ebp-0x244] */
            ii(0x1012_49dd, 6); inc(memd_a32[ss, ebp - 0x244]);         /* inc dword [ebp-0x244] */
            ii(0x1012_49e3, 2); mov(memb_a32[ds, eax], dl);             /* mov [eax], dl */
            ii(0x1012_49e5, 6); mov(al, memb_a32[ss, ebp - 0x23d]);     /* mov al, [ebp-0x23d] */
            ii(0x1012_49eb, 5); mov(memb_a32[ds, 0x101c_59bb], al);     /* mov [0x101c59bb], al */
            ii(0x1012_49f0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_49f2, 5); mov(al, memb_a32[ds, 0x101c_59bb]);     /* mov al, [0x101c59bb] */
            ii(0x1012_49f7, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1012_49fc, 2); if(jzd(0x1012_4a0c, 0xe)) goto l_0x1012_4a0c; /* jz 0x10124a0c */
            ii(0x1012_49fe, 5); mov(al, memb_a32[ds, 0x101c_59ba]);     /* mov al, [0x101c59ba] */
            ii(0x1012_4a03, 2); inc(al);                                /* inc al */
            ii(0x1012_4a05, 2); and(al, 0x3f);                          /* and al, 0x3f */
            ii(0x1012_4a07, 5); mov(memb_a32[ds, 0x101c_59ba], al);     /* mov [0x101c59ba], al */
        l_0x1012_4a0c:
            ii(0x1012_4a0c, 4); add(memd_a32[ss, ebp - 0x8], 0x5);      /* add dword [ebp-0x8], 0x5 */
        l_0x1012_4a10:
            ii(0x1012_4a10, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4a13, 6); mov(memd_a32[ss, ebp - 0x248], eax);    /* mov [ebp-0x248], eax */
            ii(0x1012_4a19, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_4a1d, 2); if(jzd(0x1012_4a2d, 0xe)) goto l_0x1012_4a2d; /* jz 0x10124a2d */
            ii(0x1012_4a1f, 6); lea(eax, ebp - 0x240);                  /* lea eax, [ebp-0x240] */
            ii(0x1012_4a25, 6); mov(memd_a32[ss, ebp - 0x244], eax);    /* mov [ebp-0x244], eax */
            ii(0x1012_4a2b, 2); jmpd(0x1012_4a39, 0xc); goto l_0x1012_4a39; /* jmp 0x10124a39 */
        l_0x1012_4a2d:
            ii(0x1012_4a2d, 6); lea(eax, ebp - 0x23d);                  /* lea eax, [ebp-0x23d] */
            ii(0x1012_4a33, 6); mov(memd_a32[ss, ebp - 0x244], eax);    /* mov [ebp-0x244], eax */
        l_0x1012_4a39:
            ii(0x1012_4a39, 6); mov(edx, memd_a32[ds, 0x101c_587c]);    /* mov edx, [0x101c587c] */
            ii(0x1012_4a3f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_4a42, 2); cmp(eax, memd_a32[ds, edx]);            /* cmp eax, [edx] */
            ii(0x1012_4a44, 6); if(jld(0x1012_4ac8, 0x7e)) goto l_0x1012_4ac8; /* jl 0x10124ac8 */
            ii(0x1012_4a4a, 5); mov(eax, 0x400);                        /* mov eax, 0x400 */
            ii(0x1012_4a4f, 3); sub(eax, memd_a32[ss, ebp - 0x10]);     /* sub eax, [ebp-0x10] */
            ii(0x1012_4a52, 6); mov(memd_a32[ss, ebp - 0x248], eax);    /* mov [ebp-0x248], eax */
            ii(0x1012_4a58, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4a5e, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1012_4a61, 2); if(jled(0x1012_4a6c, 0x9)) goto l_0x1012_4a6c; /* jle 0x10124a6c */
            ii(0x1012_4a63, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4a66, 6); mov(memd_a32[ss, ebp - 0x248], eax);    /* mov [ebp-0x248], eax */
        l_0x1012_4a6c:
            ii(0x1012_4a6c, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4a72, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4a73, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1012_4a75, 6); mov(edx, memd_a32[ss, ebp - 0x244]);    /* mov edx, [ebp-0x244] */
            ii(0x1012_4a7b, 5); mov(eax, memd_a32[ds, 0x101c_5984]);    /* mov eax, [0x101c5984] */
            ii(0x1012_4a80, 3); mov(esi, memd_a32[ss, ebp - 0x10]);     /* mov esi, [ebp-0x10] */
            ii(0x1012_4a83, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1012_4a85, 2); mov(eax, ds);                           /* mov eax, ds */
            ii(0x1012_4a87, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1012_4a89, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1012_4a8b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_4a8d, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1012_4a8f, 5); calld(/* sys */ 0x1017_d4ca, 0x5_8a36); /* call 0x1017d4ca */
            ii(0x1012_4a94, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4a9a, 6); add(memd_a32[ss, ebp - 0x244], eax);    /* add [ebp-0x244], eax */
            ii(0x1012_4aa0, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4aa6, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1012_4aa9, 7); cmp(memd_a32[ss, ebp - 0x10], 0x400);   /* cmp dword [ebp-0x10], 0x400 */
            ii(0x1012_4ab0, 2); if(jnzd(0x1012_4ab9, 0x7)) goto l_0x1012_4ab9; /* jnz 0x10124ab9 */
            ii(0x1012_4ab2, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_4ab9:
            ii(0x1012_4ab9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_4abc, 6); sub(eax, memd_a32[ss, ebp - 0x248]);    /* sub eax, [ebp-0x248] */
            ii(0x1012_4ac2, 6); mov(memd_a32[ss, ebp - 0x248], eax);    /* mov [ebp-0x248], eax */
        l_0x1012_4ac8:
            ii(0x1012_4ac8, 6); mov(eax, memd_a32[ss, ebp - 0x248]);    /* mov eax, [ebp-0x248] */
            ii(0x1012_4ace, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4acf, 2); mov(ebx, ds);                           /* mov ebx, ds */
            ii(0x1012_4ad1, 6); mov(eax, memd_a32[ss, ebp - 0x244]);    /* mov eax, [ebp-0x244] */
            ii(0x1012_4ad7, 6); mov(edi, memd_a32[ds, 0x101c_5984]);    /* mov edi, [0x101c5984] */
            ii(0x1012_4add, 3); add(edi, memd_a32[ss, ebp - 0x10]);     /* add edi, [ebp-0x10] */
            ii(0x1012_4ae0, 2); mov(esi, ds);                           /* mov esi, ds */
            ii(0x1012_4ae2, 2); mov(ecx, ebx);                          /* mov ecx, ebx */
            ii(0x1012_4ae4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_4ae6, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1012_4ae8, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1012_4aea, 5); calld(/* sys */ 0x1017_d4ca, 0x5_89db); /* call 0x1017d4ca */
            ii(0x1012_4aef, 1); cli();                                  /* cli */
            ii(0x1012_4af0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1012_4af3, 6); add(edx, memd_a32[ss, ebp - 0x248]);    /* add edx, [ebp-0x248] */
            ii(0x1012_4af9, 5); mov(eax, memd_a32[ds, 0x101c_5878]);    /* mov eax, [0x101c5878] */
            ii(0x1012_4afe, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1012_4b00, 1); sti();                                  /* sti */
            ii(0x1012_4b01, 1); cld();                                  /* cld */
            ii(0x1012_4b02, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1012_4b07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_4b09, 7); mov(dx, memw_a32[ds, 0x101b_b45c]);     /* mov dx, [0x101bb45c] */
            ii(0x1012_4b10, 1); inc(edx);                               /* inc edx */
            ii(0x1012_4b11, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1012_4b12, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_4b14, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_4b15, 1); popd(edi);                              /* pop edi */
            ii(0x1012_4b16, 1); popd(esi);                              /* pop esi */
            ii(0x1012_4b17, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_4b18, 1); retd(); return;                         /* ret */
        }
    }
}
