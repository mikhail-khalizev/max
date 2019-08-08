using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("32a78a4b-5ea3-475c-b363-6fb187c0abb6")]
        public void /* sys */ Method_1017_ba30()
        {
            ii(0x1017_ba30, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_ba31, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_ba33, 1); pushd(esi);                             /* push esi */
            ii(0x1017_ba34, 1); pushd(edi);                             /* push edi */
            ii(0x1017_ba35, 3); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1017_ba38, 5); mov(eax, memd_a32[ds, 0x1020_9c74]);    /* mov eax, [0x10209c74] */
            ii(0x1017_ba3d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1017_ba40, 5); mov(eax, memd_a32[ds, 0x1020_9c70]);    /* mov eax, [0x10209c70] */
            ii(0x1017_ba45, 6); mov(edx, memd_a32[ds, 0x101b_e458]);    /* mov edx, [0x101be458] */
            ii(0x1017_ba4b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1017_ba4e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_ba50, 2); if(jnzd(0x1017_ba5c, 0xa)) goto l_0x1017_ba5c; /* jnz 0x1017ba5c */
            ii(0x1017_ba52, 5); mov(eax, 0xffff_fff6);                  /* mov eax, 0xfffffff6 */
            ii(0x1017_ba57, 5); jmpd(0x1017_be57, 0x3fb); goto l_0x1017_be57; /* jmp 0x1017be57 */
        l_0x1017_ba5c:
            ii(0x1017_ba5c, 7); cmp(memd_a32[ds, 0x101b_e454], 0);      /* cmp dword [0x101be454], 0x0 */
            ii(0x1017_ba63, 2); if(jzd(0x1017_ba7e, 0x19)) goto l_0x1017_ba7e; /* jz 0x1017ba7e */
            ii(0x1017_ba65, 7); cmp(memd_a32[ds, 0x101b_e418], -0x1 /* 0xff */); /* cmp dword [0x101be418], 0xffffffff */
            ii(0x1017_ba6c, 2); if(jzd(0x1017_ba76, 0x8)) goto l_0x1017_ba76; /* jz 0x1017ba76 */
            ii(0x1017_ba6e, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_ba70, 6); mov(memd_a32[ds, 0x101b_e438], esi);    /* mov [0x101be438], esi */
        l_0x1017_ba76:
            ii(0x1017_ba76, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_ba78, 6); mov(memd_a32[ds, 0x101b_e454], edi);    /* mov [0x101be454], edi */
        l_0x1017_ba7e:
            ii(0x1017_ba7e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_ba80, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1017_ba83, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1017_ba86, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1017_ba89, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_ba8b, 2); if(jnzd(0x1017_ba97, 0xa)) goto l_0x1017_ba97; /* jnz 0x1017ba97 */
            ii(0x1017_ba8d, 5); mov(edx, 0xffff_fffe);                  /* mov edx, 0xfffffffe */
            ii(0x1017_ba92, 5); jmpd(0x1017_baef, 0x58); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_ba97:
            ii(0x1017_ba97, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1017_ba9a, 3); mov(ecx, memd_a32[ss, ebp - 0xc]);      /* mov ecx, [ebp-0xc] */
            ii(0x1017_ba9d, 2); add(ecx, eax);                          /* add ecx, eax */
            ii(0x1017_ba9f, 2); mov(eax, memd_a32[ds, ecx]);            /* mov eax, [ecx] */
            ii(0x1017_baa1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1017_baa4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_baa6, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1017_baa9, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1017_baad, 3); lea(esi, ecx + 0x4);                    /* lea esi, [ecx+0x4] */
            ii(0x1017_bab0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1017_bab3, 3); mov(ah, memb_a32[ss, ebp - 0xe]);       /* mov ah, [ebp-0xe] */
            ii(0x1017_bab6, 3); mov(memd_a32[ss, ebp - 0xc], esi);      /* mov [ebp-0xc], esi */
            ii(0x1017_bab9, 3); cmp(ah, 0x11);                          /* cmp ah, 0x11 */
            ii(0x1017_babc, 2); if(jad(0x1017_ba97, -0x27)) goto l_0x1017_ba97; /* ja 0x1017ba97 */
            ii(0x1017_babe, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bac0, 3); mov(al, memb_a32[ss, ebp - 0xe]);       /* mov al, [ebp-0xe] */
            ii(0x1017_bac3, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, eax * 4 + /* sys */ 0x1017_b9e8]))
            {
                case 0x1017_bacb:
                    goto l_0x1017_bacb;
                case 0x1017_bad9:
                    goto l_0x1017_bad9;
                case 0x1017_bb18:
                    goto l_0x1017_bb18;
                case 0x1017_bb90:
                    goto l_0x1017_bb90;
                case 0x1017_bb9a:
                    goto l_0x1017_bb9a;
                case 0x1017_bc70:
                    goto l_0x1017_bc70;
                case 0x1017_bcbf:
                    goto l_0x1017_bcbf;
                case 0x1017_be5e:
                    goto l_0x1017_be5e;
                case 0x1017_be97:
                    goto l_0x1017_be97;
                case 0x1017_bf21:
                    goto l_0x1017_bf21;
                case 0x1017_bf53:
                    goto l_0x1017_bf53;
                case 0x1017_bf8b:
                    goto l_0x1017_bf8b;
                case 0x1017_bf9e:
                    goto l_0x1017_bf9e;
                case 0x1017_bfa6:
                    goto l_0x1017_bfa6;
                case 0x1017_bfae:
                    goto l_0x1017_bfae;
                case 0x1017_c005:
                    goto l_0x1017_c005;
                case 0x1017_c12e:
                    goto l_0x1017_c12e;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x1017b9e8] */
        l_0x1017_bacb:
            ii(0x1017_bacb, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_bad0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_bad2, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_bad5, 1); popd(edi);                              /* pop edi */
            ii(0x1017_bad6, 1); popd(esi);                              /* pop esi */
            ii(0x1017_bad7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_bad8, 1); retd(); return;                         /* ret */
        l_0x1017_bad9:
            ii(0x1017_bad9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_badb, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1017_badd, 4); mov(dx, memw_a32[ds, esi + 0x4]);       /* mov dx, [esi+0x4] */
            ii(0x1017_bae1, 5); calld(/* sys */ 0x1017_96b0, -0x2436);  /* call 0x101796b0 */
            ii(0x1017_bae6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_bae8, 2); if(jnzd(0x1017_ba97, -0x53)) goto l_0x1017_ba97; /* jnz 0x1017ba97 */
            ii(0x1017_baea, 5); mov(edx, 0xffff_fffd);                  /* mov edx, 0xfffffffd */
        l_0x1017_baef:
            ii(0x1017_baef, 7); cmp(memd_a32[ds, 0x101b_e458], 0);      /* cmp dword [0x101be458], 0x0 */
            ii(0x1017_baf6, 2); if(jzd(0x1017_bb0f, 0x17)) goto l_0x1017_bb0f; /* jz 0x1017bb0f */
            ii(0x1017_baf8, 5); calld(/* sys */ 0x1017_97f0, -0x230d);  /* call 0x101797f0 */
            ii(0x1017_bafd, 5); calld(/* sys */ 0x1017_9650, -0x24b2);  /* call 0x10179650 */
            ii(0x1017_bb02, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1017_bb04, 5); calld(/* sys */ 0x1017_9cb0, -0x1e59);  /* call 0x10179cb0 */
            ii(0x1017_bb09, 6); mov(memd_a32[ds, 0x101b_e458], esi);    /* mov [0x101be458], esi */
        l_0x1017_bb0f:
            ii(0x1017_bb0f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_bb11, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_bb14, 1); popd(edi);                              /* pop edi */
            ii(0x1017_bb15, 1); popd(esi);                              /* pop esi */
            ii(0x1017_bb16, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_bb17, 1); retd(); return;                         /* ret */
        l_0x1017_bb18:
            ii(0x1017_bb18, 3); mov(dh, memb_a32[ss, ebp - 0xd]);       /* mov dh, [ebp-0xd] */
            ii(0x1017_bb1b, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_bb1d, 3); cmp(dh, 0x1);                           /* cmp dh, 0x1 */
            ii(0x1017_bb20, 2); if(jbd(0x1017_bb35, 0x13)) goto l_0x1017_bb35; /* jb 0x1017bb35 */
            ii(0x1017_bb22, 4); mov(dx, memw_a32[ds, esi + 0x2]);       /* mov dx, [esi+0x2] */
            ii(0x1017_bb26, 3); shl(edx, 0xd);                          /* shl edx, 0xd */
            ii(0x1017_bb29, 4); shr(dx, 0xf);                           /* shr dx, 0xf */
            ii(0x1017_bb2d, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1017_bb33, 2); jmpd(0x1017_bb37, 0x2); goto l_0x1017_bb37; /* jmp 0x1017bb37 */
        l_0x1017_bb35:
            ii(0x1017_bb35, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1017_bb37:
            ii(0x1017_bb37, 3); mov(cl, memb_a32[ss, ebp - 0xd]);       /* mov cl, [ebp-0xd] */
            ii(0x1017_bb3a, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_bb3c, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1017_bb3f, 2); test(cl, cl);                           /* test cl, cl */
            ii(0x1017_bb41, 2); if(jnzd(0x1017_bb49, 0x6)) goto l_0x1017_bb49; /* jnz 0x1017bb49 */
            ii(0x1017_bb43, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
        l_0x1017_bb49:
            ii(0x1017_bb49, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_bb4a, 4); mov(bx, memw_a32[ds, eax + 0x2]);       /* mov bx, [eax+0x2] */
            ii(0x1017_bb4e, 3); shl(ebx, 0xe);                          /* shl ebx, 0xe */
            ii(0x1017_bb51, 4); shr(bx, 0xf);                           /* shr bx, 0xf */
            ii(0x1017_bb55, 6); and(ebx, 0xffff);                       /* and ebx, 0xffff */
            ii(0x1017_bb5b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_bb5d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_bb5e, 4); mov(bx, memw_a32[ds, eax + 0x2]);       /* mov bx, [eax+0x2] */
            ii(0x1017_bb62, 4); mov(cx, memw_a32[ds, eax + 0x4]);       /* mov cx, [eax+0x4] */
            ii(0x1017_bb66, 3); and(bl, 0x1);                           /* and bl, 0x1 */
            ii(0x1017_bb69, 2); xor(bh, bh);                            /* xor bh, bh */
            ii(0x1017_bb6b, 6); and(ebx, 0xffff);                       /* and ebx, 0xffff */
            ii(0x1017_bb71, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1017_bb74, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_bb79, 5); calld(/* sys */ 0x1017_9cf0, -0x1e8e);  /* call 0x10179cf0 */
            ii(0x1017_bb7e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_bb80, 6); if(jnzd(0x1017_ba97, -0xef)) goto l_0x1017_ba97; /* jnz 0x1017ba97 */
            ii(0x1017_bb86, 5); mov(edx, 0xffff_fffc);                  /* mov edx, 0xfffffffc */
            ii(0x1017_bb8b, 5); jmpd(0x1017_baef, -0xa1); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_bb90:
            ii(0x1017_bb90, 5); calld(/* sys */ 0x1017_9f60, -0x1c35);  /* call 0x10179f60 */
            ii(0x1017_bb95, 5); jmpd(0x1017_ba97, -0x103); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bb9a:
            ii(0x1017_bb9a, 3); mov(bh, memb_a32[ss, ebp - 0xd]);       /* mov bh, [ebp-0xd] */
            ii(0x1017_bb9d, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_bb9f, 3); cmp(bh, 0x2);                           /* cmp bh, 0x2 */
            ii(0x1017_bba2, 2); if(jbd(0x1017_bbac, 0x8)) goto l_0x1017_bbac; /* jb 0x1017bbac */
            ii(0x1017_bba4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bba6, 4); mov(dx, memw_a32[ds, esi + 0x6]);       /* mov dx, [esi+0x6] */
            ii(0x1017_bbaa, 2); jmpd(0x1017_bbae, 0x2); goto l_0x1017_bbae; /* jmp 0x1017bbae */
        l_0x1017_bbac:
            ii(0x1017_bbac, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1017_bbae:
            ii(0x1017_bbae, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_bbb0, 4); cmp(memb_a32[ss, ebp - 0xd], 0x1);      /* cmp byte [ebp-0xd], 0x1 */
            ii(0x1017_bbb4, 2); if(jbd(0x1017_bbbe, 0x8)) goto l_0x1017_bbbe; /* jb 0x1017bbbe */
            ii(0x1017_bbb6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_bbb8, 4); mov(bx, memw_a32[ds, eax + 0x4]);       /* mov bx, [eax+0x4] */
            ii(0x1017_bbbc, 2); jmpd(0x1017_bbc3, 0x5); goto l_0x1017_bbc3; /* jmp 0x1017bbc3 */
        l_0x1017_bbbe:
            ii(0x1017_bbbe, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
        l_0x1017_bbc3:
            ii(0x1017_bbc3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bbc5, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x1017_bbc9, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x1017_bbcc, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_bbd1, 5); calld(/* sys */ 0x1017_a450, -0x1786);  /* call 0x1017a450 */
            ii(0x1017_bbd6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_bbd8, 2); if(jnzd(0x1017_bbe4, 0xa)) goto l_0x1017_bbe4; /* jnz 0x1017bbe4 */
            ii(0x1017_bbda, 5); mov(edx, 0xffff_fffb);                  /* mov edx, 0xfffffffb */
            ii(0x1017_bbdf, 5); jmpd(0x1017_baef, -0xf5); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_bbe4:
            ii(0x1017_bbe4, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1017_bbe9, 6); mov(esi, memd_a32[ds, 0x101b_e204]);    /* mov esi, [0x101be204] */
            ii(0x1017_bbef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bbf1, 7); lea(eax, eax * 4 + 0);                  /* lea eax, [eax*4] */
            ii(0x1017_bbf8, 2); div(esi);                               /* div esi */
            ii(0x1017_bbfa, 6); mov(edi, memd_a32[ds, 0x1020_9ccc]);    /* mov edi, [0x10209ccc] */
            ii(0x1017_bc00, 2); and(al, 0xf0);                          /* and al, 0xf0 */
            ii(0x1017_bc02, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_bc04, 2); if(jzd(0x1017_bc08, 0x2)) goto l_0x1017_bc08; /* jz 0x1017bc08 */
            ii(0x1017_bc06, 2); shr(eax, 0x1);                          /* shr eax, 1 */
        l_0x1017_bc08:
            ii(0x1017_bc08, 6); mov(edx, memd_a32[ds, 0x1020_9c84]);    /* mov edx, [0x10209c84] */
            ii(0x1017_bc0e, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1017_bc10, 2); if(jged(0x1017_bc14, 0x2)) goto l_0x1017_bc14; /* jge 0x1017bc14 */
            ii(0x1017_bc12, 2); xor(edx, edx);                          /* xor edx, edx */
        l_0x1017_bc14:
            ii(0x1017_bc14, 6); mov(ebx, memd_a32[ds, 0x1020_9cb4]);    /* mov ebx, [0x10209cb4] */
            ii(0x1017_bc1a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_bc1c, 2); cmp(eax, ebx);                          /* cmp eax, ebx */
            ii(0x1017_bc1e, 2); if(jad(0x1017_bc42, 0x22)) goto l_0x1017_bc42; /* ja 0x1017bc42 */
            ii(0x1017_bc20, 6); mov(ecx, memd_a32[ds, 0x1020_9c88]);    /* mov ecx, [0x10209c88] */
            ii(0x1017_bc26, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_bc28, 2); if(jged(0x1017_bc2e, 0x4)) goto l_0x1017_bc2e; /* jge 0x1017bc2e */
            ii(0x1017_bc2a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bc2c, 2); jmpd(0x1017_bc30, 0x2); goto l_0x1017_bc30; /* jmp 0x1017bc30 */
        l_0x1017_bc2e:
            ii(0x1017_bc2e, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1017_bc30:
            ii(0x1017_bc30, 6); mov(esi, memd_a32[ds, 0x1020_9cf0]);    /* mov esi, [0x10209cf0] */
            ii(0x1017_bc36, 6); mov(edi, memd_a32[ds, 0x1020_9cbc]);    /* mov edi, [0x10209cbc] */
            ii(0x1017_bc3c, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1017_bc3e, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1017_bc40, 2); if(jbed(0x1017_bc4c, 0xa)) goto l_0x1017_bc4c; /* jbe 0x1017bc4c */
        l_0x1017_bc42:
            ii(0x1017_bc42, 5); mov(edx, 0xffff_fffa);                  /* mov edx, 0xfffffffa */
            ii(0x1017_bc47, 5); jmpd(0x1017_baef, -0x15d); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_bc4c:
            ii(0x1017_bc4c, 7); cmp(memd_a32[ds, 0x1020_9ccc], 0);      /* cmp dword [0x10209ccc], 0x0 */
            ii(0x1017_bc53, 6); if(jzd(0x1017_ba97, -0x1c2)) goto l_0x1017_ba97; /* jz 0x1017ba97 */
            ii(0x1017_bc59, 7); cmp(memd_a32[ds, 0x1020_9c94], 0);      /* cmp dword [0x10209c94], 0x0 */
            ii(0x1017_bc60, 6); if(jnzd(0x1017_ba97, -0x1cf)) goto l_0x1017_ba97; /* jnz 0x1017ba97 */
            ii(0x1017_bc66, 5); mov(edx, 0xffff_fffa);                  /* mov edx, 0xfffffffa */
            ii(0x1017_bc6b, 5); jmpd(0x1017_baef, -0x181); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_bc70:
            ii(0x1017_bc70, 3); mov(bl, memb_a32[ds, esi + 0xc]);       /* mov bl, [esi+0xc] */
            ii(0x1017_bc73, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_bc75, 3); test(bl, 0x1);                          /* test bl, 0x1 */
            ii(0x1017_bc78, 2); if(jzd(0x1017_bc92, 0x18)) goto l_0x1017_bc92; /* jz 0x1017bc92 */
            ii(0x1017_bc7a, 6); mov(ebx, memd_a32[ds, 0x1020_9cc8]);    /* mov ebx, [0x10209cc8] */
            ii(0x1017_bc80, 6); mov(edx, memd_a32[ds, 0x1020_9cd8]);    /* mov edx, [0x10209cd8] */
            ii(0x1017_bc86, 6); mov(memd_a32[ds, 0x1020_9cd8], ebx);    /* mov [0x10209cd8], ebx */
            ii(0x1017_bc8c, 6); mov(memd_a32[ds, 0x1020_9cc8], edx);    /* mov [0x10209cc8], edx */
        l_0x1017_bc92:
            ii(0x1017_bc92, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bc94, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1017_bc98, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bc99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bc9b, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1017_bc9f, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bca0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bca2, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x1017_bca6, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bca7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bca9, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1017_bcad, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bcae, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1017_bcb1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bcb2, 5); calld(/* sys */ 0x1018_e37a, 0x1_26c3); /* call 0x1018e37a */
            ii(0x1017_bcb7, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1017_bcba, 5); jmpd(0x1017_ba97, -0x228); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bcbf:
            ii(0x1017_bcbf, 6); inc(memd_a32[ds, 0x1020_9c7c]);         /* inc dword [0x10209c7c] */
            ii(0x1017_bcc5, 3); mov(al, memb_a32[ss, ebp - 0xd]);       /* mov al, [ebp-0xd] */
            ii(0x1017_bcc8, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_bcca, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1017_bccc, 2); if(jbd(0x1017_bcd2, 0x4)) goto l_0x1017_bcd2; /* jb 0x1017bcd2 */
            ii(0x1017_bcce, 4); mov(di, memw_a32[ds, esi + 0x4]);       /* mov di, [esi+0x4] */
        l_0x1017_bcd2:
            ii(0x1017_bcd2, 7); cmp(memd_a32[ds, 0x101b_e210], 0);      /* cmp dword [0x101be210], 0x0 */
            ii(0x1017_bcd9, 2); if(jnzd(0x1017_bcfa, 0x1f)) goto l_0x1017_bcfa; /* jnz 0x1017bcfa */
            ii(0x1017_bcdb, 5); cmp(memw_a32[ds, esi + 0x2], 0);        /* cmp word [esi+0x2], 0x0 */
            ii(0x1017_bce0, 2); if(jzd(0x1017_bcfa, 0x18)) goto l_0x1017_bcfa; /* jz 0x1017bcfa */
            ii(0x1017_bce2, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1017_bce6, 2); if(jnzd(0x1017_bcfa, 0x12)) goto l_0x1017_bcfa; /* jnz 0x1017bcfa */
            ii(0x1017_bce8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bcea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bcec, 4); mov(dx, memw_a32[ds, esi + 0x2]);       /* mov dx, [esi+0x2] */
            ii(0x1017_bcf0, 3); mov(ax, memw_a32[ds, esi]);             /* mov ax, [esi] */
            ii(0x1017_bcf3, 5); calld(/* sys */ 0x1017_aa80, -0x1278);  /* call 0x1017aa80 */
            ii(0x1017_bcf8, 2); jmpd(0x1017_bd28, 0x2e); goto l_0x1017_bd28; /* jmp 0x1017bd28 */
        l_0x1017_bcfa:
            ii(0x1017_bcfa, 7); cmp(memd_a32[ds, 0x101b_e210], 0);      /* cmp dword [0x101be210], 0x0 */
            ii(0x1017_bd01, 2); if(jnzd(0x1017_bd28, 0x25)) goto l_0x1017_bd28; /* jnz 0x1017bd28 */
            ii(0x1017_bd03, 6); mov(ebx, memd_a32[ds, 0x1020_9c94]);    /* mov ebx, [0x10209c94] */
            ii(0x1017_bd09, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bd0b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bd0d, 3); mov(ax, memw_a32[ds, esi]);             /* mov ax, [esi] */
            ii(0x1017_bd10, 4); mov(dx, memw_a32[ds, esi + 0x2]);       /* mov dx, [esi+0x2] */
            ii(0x1017_bd14, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_bd16, 2); if(jnzd(0x1017_bd28, 0x10)) goto l_0x1017_bd28; /* jnz 0x1017bd28 */
            ii(0x1017_bd18, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bd19, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bd1a, 5); pushd(0x1020_9750);                     /* push 0x10209750 */
            ii(0x1017_bd1f, 6); calld_abs(memd_a32[ds, 0x101b_e450]);   /* call dword [0x101be450] */ /* Вызов '0x1019_4101'. */
            ii(0x1017_bd25, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x1017_bd28:
            ii(0x1017_bd28, 3); mov(ecx, memd_a32[ss, ebp - 0x1c]);     /* mov ecx, [ebp-0x1c] */
            ii(0x1017_bd2b, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_bd2d, 2); if(jzd(0x1017_bd43, 0x14)) goto l_0x1017_bd43; /* jz 0x1017bd43 */
            ii(0x1017_bd2f, 6); mov(edx, memd_a32[ds, 0x1020_9c88]);    /* mov edx, [0x10209c88] */
            ii(0x1017_bd35, 5); mov(eax, memd_a32[ds, 0x1020_9c84]);    /* mov eax, [0x10209c84] */
            ii(0x1017_bd3a, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1017_bd3c, 5); calld(/* sys */ 0x1017_a8c0, -0x1481);  /* call 0x1017a8c0 */
            ii(0x1017_bd41, 2); jmpd(0x1017_bd80, 0x3d); goto l_0x1017_bd80; /* jmp 0x1017bd80 */
        l_0x1017_bd43:
            ii(0x1017_bd43, 7); cmp(memd_a32[ds, 0x101b_e424], 0);      /* cmp dword [0x101be424], 0x0 */
            ii(0x1017_bd4a, 2); if(jzd(0x1017_bd6e, 0x22)) goto l_0x1017_bd6e; /* jz 0x1017bd6e */
            ii(0x1017_bd4c, 5); cmp(memw_a32[ds, esi + 0x2], 0);        /* cmp word [esi+0x2], 0x0 */
            ii(0x1017_bd51, 2); if(jnzd(0x1017_bd6e, 0x1b)) goto l_0x1017_bd6e; /* jnz 0x1017bd6e */
            ii(0x1017_bd53, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_bd58, 6); mov(ebx, memd_a32[ds, 0x1020_9c78]);    /* mov ebx, [0x10209c78] */
            ii(0x1017_bd5e, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1017_bd60, 6); mov(memd_a32[ds, 0x101b_e428], edx);    /* mov [0x101be428], edx */
            ii(0x1017_bd66, 6); mov(memd_a32[ds, 0x1020_9c78], ebx);    /* mov [0x10209c78], ebx */
            ii(0x1017_bd6c, 2); jmpd(0x1017_bd80, 0x12); goto l_0x1017_bd80; /* jmp 0x1017bd80 */
        l_0x1017_bd6e:
            ii(0x1017_bd6e, 6); mov(edx, memd_a32[ds, 0x1020_9c88]);    /* mov edx, [0x10209c88] */
            ii(0x1017_bd74, 5); mov(eax, memd_a32[ds, 0x1020_9c84]);    /* mov eax, [0x10209c84] */
            ii(0x1017_bd79, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1017_bd7b, 5); calld(/* sys */ 0x1017_a6c0, -0x16c0);  /* call 0x1017a6c0 */
        l_0x1017_bd80:
            ii(0x1017_bd80, 7); cmp(memd_a32[ds, 0x101b_e210], 0);      /* cmp dword [0x101be210], 0x0 */
            ii(0x1017_bd87, 2); if(jnzd(0x1017_bdc5, 0x3c)) goto l_0x1017_bdc5; /* jnz 0x1017bdc5 */
            ii(0x1017_bd89, 4); mov(cx, memw_a32[ds, esi + 0x2]);       /* mov cx, [esi+0x2] */
            ii(0x1017_bd8d, 3); test(cx, cx);                           /* test cx, cx */
            ii(0x1017_bd90, 2); if(jzd(0x1017_bdc5, 0x33)) goto l_0x1017_bdc5; /* jz 0x1017bdc5 */
            ii(0x1017_bd92, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1017_bd96, 2); if(jnzd(0x1017_bdc5, 0x2d)) goto l_0x1017_bdc5; /* jnz 0x1017bdc5 */
            ii(0x1017_bd98, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bd9a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bd9c, 3); mov(ax, cx);                            /* mov ax, cx */
            ii(0x1017_bd9f, 6); mov(ecx, memd_a32[ds, 0x1020_9c94]);    /* mov ecx, [0x10209c94] */
            ii(0x1017_bda5, 3); mov(dx, memw_a32[ds, esi]);             /* mov dx, [esi] */
            ii(0x1017_bda8, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_bdaa, 6); if(jnzd(0x1017_be45, 0x95)) goto l_0x1017_be45; /* jnz 0x1017be45 */
            ii(0x1017_bdb0, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bdb1, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bdb2, 5); pushd(0x1020_9750);                     /* push 0x10209750 */
            ii(0x1017_bdb7, 6); calld_abs(memd_a32[ds, 0x101b_e450]);   /* call dword [0x101be450] */ /* Вызов '0x1019_4101'. */
            ii(0x1017_bdbd, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1017_bdc0, 5); jmpd(0x1017_be45, 0x80); goto l_0x1017_be45; /* jmp 0x1017be45 */
        l_0x1017_bdc5:
            ii(0x1017_bdc5, 7); cmp(memd_a32[ds, 0x101b_e210], 0);      /* cmp dword [0x101be210], 0x0 */
            ii(0x1017_bdcc, 6); if(jzd(0x1017_be45, 0x73)) goto l_0x1017_be45; /* jz 0x1017be45 */
            ii(0x1017_bdd2, 5); cmp(memw_a32[ds, esi + 0x2], 0);        /* cmp word [esi+0x2], 0x0 */
            ii(0x1017_bdd7, 2); if(jzd(0x1017_bdee, 0x15)) goto l_0x1017_bdee; /* jz 0x1017bdee */
            ii(0x1017_bdd9, 1); cli();                                  /* cli */
            ii(0x1017_bdda, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_bddc, 5); calld(/* sys */ 0x1019_4357, 0x1_8576); /* call 0x10194357 */
            ii(0x1017_bde1, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_bde4, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_bde6, 5); calld(/* sys */ 0x1019_4357, 0x1_856c); /* call 0x10194357 */
            ii(0x1017_bdeb, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_bdee:
            ii(0x1017_bdee, 6); mov(edx, memd_a32[ds, 0x101b_e208]);    /* mov edx, [0x101be208] */
            ii(0x1017_bdf4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bdf6, 7); mov(edx, memd_a32[ds, edx * 4 + 0x101b_e20c]); /* mov edx, [edx*4+0x101be20c] */
            ii(0x1017_bdfd, 5); calld(/* sys */ 0x1018_cbb0, 0x1_0dae); /* call 0x1018cbb0 */
            ii(0x1017_be02, 5); cmp(memw_a32[ds, esi + 0x2], 0);        /* cmp word [esi+0x2], 0x0 */
            ii(0x1017_be07, 2); if(jzd(0x1017_be13, 0xa)) goto l_0x1017_be13; /* jz 0x1017be13 */
            ii(0x1017_be09, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_be0b, 5); calld(/* sys */ 0x1019_4357, 0x1_8547); /* call 0x10194357 */
            ii(0x1017_be10, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        l_0x1017_be13:
            ii(0x1017_be13, 6); mov(ebx, memd_a32[ds, 0x1020_9c94]);    /* mov ebx, [0x10209c94] */
            ii(0x1017_be19, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_be1b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_be1d, 3); mov(dx, memw_a32[ds, esi]);             /* mov dx, [esi] */
            ii(0x1017_be20, 4); mov(ax, memw_a32[ds, esi + 0x2]);       /* mov ax, [esi+0x2] */
            ii(0x1017_be24, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_be26, 2); if(jnzd(0x1017_be38, 0x10)) goto l_0x1017_be38; /* jnz 0x1017be38 */
            ii(0x1017_be28, 1); pushd(eax);                             /* push eax */
            ii(0x1017_be29, 1); pushd(edx);                             /* push edx */
            ii(0x1017_be2a, 5); pushd(0x1020_9750);                     /* push 0x10209750 */
            ii(0x1017_be2f, 6); calld_abs(memd_a32[ds, 0x101b_e450]);   /* call dword [0x101be450] */ /* Вызов '0x1019_4101'. */
            ii(0x1017_be35, 3); add(esp, 0xc);                          /* add esp, 0xc */
        l_0x1017_be38:
            ii(0x1017_be38, 5); cmp(memw_a32[ds, esi + 0x2], 0);        /* cmp word [esi+0x2], 0x0 */
            ii(0x1017_be3d, 6); if(jzd(0x1017_be45, 0x2)) goto l_0x1017_be45; /* jz 0x1017be45 */
            ii(0x1017_be43, 1); sti();                                  /* sti */
            ii(0x1017_be44, 1); cld();                                  /* cld */
        l_0x1017_be45:
            ii(0x1017_be45, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1017_be48, 5); mov(memd_a32[ds, 0x1020_9c70], eax);    /* mov [0x10209c70], eax */
            ii(0x1017_be4d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1017_be50, 5); mov(memd_a32[ds, 0x1020_9c74], eax);    /* mov [0x10209c74], eax */
            ii(0x1017_be55, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_be57:
            ii(0x1017_be57, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_be5a, 1); popd(edi);                              /* pop edi */
            ii(0x1017_be5b, 1); popd(esi);                              /* pop esi */
            ii(0x1017_be5c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_be5d, 1); retd(); return;                         /* ret */
        l_0x1017_be5e:
            ii(0x1017_be5e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1017_be61, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_be63, 6); mov(esi, memd_a32[ds, 0x1020_9c80]);    /* mov esi, [0x10209c80] */
            ii(0x1017_be69, 4); mov(ax, memw_a32[ds, edx + 0x2]);       /* mov ax, [edx+0x2] */
            ii(0x1017_be6d, 2); test(eax, esi);                         /* test eax, esi */
            ii(0x1017_be6f, 6); if(jzd(0x1017_ba97, -0x3de)) goto l_0x1017_ba97; /* jz 0x1017ba97 */
            ii(0x1017_be75, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1017_be78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_be7a, 3); mov(ch, memb_a32[ss, ebp - 0xe]);       /* mov ch, [ebp-0xe] */
            ii(0x1017_be7d, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1017_be81, 3); cmp(ch, 0x8);                           /* cmp ch, 0x8 */
            ii(0x1017_be84, 2); if(jnzd(0x1017_be8b, 0x5)) goto l_0x1017_be8b; /* jnz 0x1017be8b */
            ii(0x1017_be86, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1017_be89, 2); jmpd(0x1017_be8d, 0x2); goto l_0x1017_be8d; /* jmp 0x1017be8d */
        l_0x1017_be8b:
            ii(0x1017_be8b, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1017_be8d:
            ii(0x1017_be8d, 5); calld(/* sys */ 0x1017_a1d0, -0x1cc2);  /* call 0x1017a1d0 */
            ii(0x1017_be92, 5); jmpd(0x1017_ba97, -0x400); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_be97:
            ii(0x1017_be97, 7); cmp(memd_a32[ds, 0x101b_e448], 0);      /* cmp dword [0x101be448], 0x0 */
            ii(0x1017_be9e, 6); if(jzd(0x1017_ba97, -0x40d)) goto l_0x1017_ba97; /* jz 0x1017ba97 */
            ii(0x1017_bea4, 6); mov(ecx, memd_a32[ds, 0x101b_e200]);    /* mov ecx, [0x101be200] */
            ii(0x1017_beaa, 4); mov(si, memw_a32[ds, esi + 0x4]);       /* mov si, [esi+0x4] */
            ii(0x1017_beae, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1017_beb0, 2); if(jzd(0x1017_bec1, 0xf)) goto l_0x1017_bec1; /* jz 0x1017bec1 */
            ii(0x1017_beb2, 7); test(memb_a32[ds, 0x101b_e200], 0x4);   /* test byte [0x101be200], 0x4 */
            ii(0x1017_beb9, 2); if(jnzd(0x1017_bec1, 0x6)) goto l_0x1017_bec1; /* jnz 0x1017bec1 */
            ii(0x1017_bebb, 6); or(esi, 0x8000);                        /* or esi, 0x8000 */
        l_0x1017_bec1:
            ii(0x1017_bec1, 6); mov(edi, memd_a32[ds, 0x101b_e44c]);    /* mov edi, [0x101be44c] */
            ii(0x1017_bec7, 3); movsx(eax, si);                         /* movsx eax, si */
            ii(0x1017_beca, 2); cmp(eax, edi);                          /* cmp eax, edi */
            ii(0x1017_becc, 2); if(jzd(0x1017_bf09, 0x3b)) goto l_0x1017_bf09; /* jz 0x1017bf09 */
            ii(0x1017_bece, 3); movsx(eax, si);                         /* movsx eax, si */
            ii(0x1017_bed1, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bed2, 5); calld(/* sys */ 0x1017_b570, -0x967);   /* call 0x1017b570 */
            ii(0x1017_bed7, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_beda, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_bedc, 2); if(jnzd(0x1017_bee8, 0xa)) goto l_0x1017_bee8; /* jnz 0x1017bee8 */
            ii(0x1017_bede, 5); mov(edx, 0xffff_fff9);                  /* mov edx, 0xfffffff9 */
            ii(0x1017_bee3, 5); jmpd(0x1017_baef, -0x3f9); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_bee8:
            ii(0x1017_bee8, 7); cmp(memd_a32[ds, 0x101b_e214], 0);      /* cmp dword [0x101be214], 0x0 */
            ii(0x1017_beef, 2); if(jzd(0x1017_bf09, 0x18)) goto l_0x1017_bf09; /* jz 0x1017bf09 */
            ii(0x1017_bef1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bef3, 5); mov(eax, memd_a32[ds, 0x1020_9cc0]);    /* mov eax, [0x10209cc0] */
            ii(0x1017_bef8, 6); mov(memd_a32[ds, 0x101b_e208], edx);    /* mov [0x101be208], edx */
            ii(0x1017_befe, 6); mov(memd_a32[ds, 0x101b_e20c], edx);    /* mov [0x101be20c], edx */
            ii(0x1017_bf04, 5); mov(memd_a32[ds, 0x101b_e210], eax);    /* mov [0x101be210], eax */
        l_0x1017_bf09:
            ii(0x1017_bf09, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1017_bf0e, 3); movsx(eax, si);                         /* movsx eax, si */
            ii(0x1017_bf11, 6); mov(memd_a32[ds, 0x101b_e448], ecx);    /* mov [0x101be448], ecx */
            ii(0x1017_bf17, 5); mov(memd_a32[ds, 0x101b_e44c], eax);    /* mov [0x101be44c], eax */
            ii(0x1017_bf1c, 5); jmpd(0x1017_ba97, -0x48a); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bf21:
            ii(0x1017_bf21, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_bf23, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bf25, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_bf27, 3); mov(al, memb_a32[ds, esi + 0x5]);       /* mov al, [esi+0x5] */
            ii(0x1017_bf2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_bf2c, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bf2d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bf2f, 3); mov(cl, memb_a32[ds, esi + 0x3]);       /* mov cl, [esi+0x3] */
            ii(0x1017_bf32, 3); mov(al, memb_a32[ds, esi + 0x4]);       /* mov al, [esi+0x4] */
            ii(0x1017_bf35, 3); mov(bl, memb_a32[ds, esi + 0x2]);       /* mov bl, [esi+0x2] */
            ii(0x1017_bf38, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bf39, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_bf3b, 2); xor(edx, esi);                          /* xor edx, esi */
            ii(0x1017_bf3d, 2); xor(eax, esi);                          /* xor eax, esi */
            ii(0x1017_bf3f, 3); mov(dl, memb_a32[ds, esi + 0x1]);       /* mov dl, [esi+0x1] */
            ii(0x1017_bf42, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1017_bf44, 5); calld(/* sys */ 0x1017_aab0, -0x1499);  /* call 0x1017aab0 */
            ii(0x1017_bf49, 5); calld(/* sys */ 0x1017_a9e0, -0x156e);  /* call 0x1017a9e0 */
            ii(0x1017_bf4e, 5); jmpd(0x1017_ba97, -0x4bc); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bf53:
            ii(0x1017_bf53, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1017_bf56, 5); mov(edi, 0x1020_9750);                  /* mov edi, 0x10209750 */
            ii(0x1017_bf5b, 3); add(esi, 0x4);                          /* add esi, 0x4 */
            ii(0x1017_bf5e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_bf60, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_bf62, 3); mov(ax, memw_a32[ds, edx]);             /* mov ax, [edx] */
            ii(0x1017_bf65, 4); mov(cx, memw_a32[ds, edx + 0x2]);       /* mov cx, [edx+0x2] */
            ii(0x1017_bf69, 3); lea(eax, eax + eax * 2);                /* lea eax, [eax+eax*2] */
            ii(0x1017_bf6c, 3); lea(ecx, ecx + ecx * 2);                /* lea ecx, [ecx+ecx*2] */
            ii(0x1017_bf6f, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1017_bf71, 1); pushd(edi);                             /* push edi */
            ii(0x1017_bf72, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1017_bf74, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1017_bf77, 2); repne_a32(() => movsd_a32());           /* repne movsd */
            ii(0x1017_bf79, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1017_bf7b, 3); and(cl, 0x3);                           /* and cl, 0x3 */
            ii(0x1017_bf7e, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1017_bf80, 1); popd(edi);                              /* pop edi */
            ii(0x1017_bf81, 5); calld(/* sys */ 0x1017_a9e0, -0x15a6);  /* call 0x1017a9e0 */
            ii(0x1017_bf86, 5); jmpd(0x1017_ba97, -0x4f4); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bf8b:
            ii(0x1017_bf8b, 1); pushd(esi);                             /* push esi */
            ii(0x1017_bf8c, 5); calld(/* sys */ 0x1019_4142, 0x1_81b1); /* call 0x10194142 */
            ii(0x1017_bf91, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_bf94, 5); calld(/* sys */ 0x1017_a9e0, -0x15b9);  /* call 0x1017a9e0 */
            ii(0x1017_bf99, 5); jmpd(0x1017_ba97, -0x507); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bf9e:
            ii(0x1017_bf9e, 3); mov(memd_a32[ss, ebp - 0x1c], esi);     /* mov [ebp-0x1c], esi */
            ii(0x1017_bfa1, 5); jmpd(0x1017_ba97, -0x50f); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bfa6:
            ii(0x1017_bfa6, 3); mov(memd_a32[ss, ebp - 0x14], esi);     /* mov [ebp-0x14], esi */
            ii(0x1017_bfa9, 5); jmpd(0x1017_ba97, -0x517); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_bfae:
            ii(0x1017_bfae, 3); mov(bh, memb_a32[ds, esi + 0xc]);       /* mov bh, [esi+0xc] */
            ii(0x1017_bfb1, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_bfb3, 3); test(bh, 0x1);                          /* test bh, 0x1 */
            ii(0x1017_bfb6, 2); if(jzd(0x1017_bfd0, 0x18)) goto l_0x1017_bfd0; /* jz 0x1017bfd0 */
            ii(0x1017_bfb8, 6); mov(edx, memd_a32[ds, 0x1020_9cc8]);    /* mov edx, [0x10209cc8] */
            ii(0x1017_bfbe, 6); mov(ebx, memd_a32[ds, 0x1020_9cd8]);    /* mov ebx, [0x10209cd8] */
            ii(0x1017_bfc4, 6); mov(memd_a32[ds, 0x1020_9cd8], edx);    /* mov [0x10209cd8], edx */
            ii(0x1017_bfca, 6); mov(memd_a32[ds, 0x1020_9cc8], ebx);    /* mov [0x10209cc8], ebx */
        l_0x1017_bfd0:
            ii(0x1017_bfd0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bfd2, 4); mov(dx, memw_a32[ds, eax + 0xa]);       /* mov dx, [eax+0xa] */
            ii(0x1017_bfd6, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bfd7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bfd9, 4); mov(dx, memw_a32[ds, eax + 0x8]);       /* mov dx, [eax+0x8] */
            ii(0x1017_bfdd, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bfde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bfe0, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x1017_bfe4, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bfe5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_bfe7, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1017_bfeb, 1); pushd(edx);                             /* push edx */
            ii(0x1017_bfec, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1017_bfef, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bff0, 3); mov(edi, memd_a32[ss, ebp - 0x14]);     /* mov edi, [ebp-0x14] */
            ii(0x1017_bff3, 1); pushd(edi);                             /* push edi */
            ii(0x1017_bff4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1017_bff7, 1); pushd(eax);                             /* push eax */
            ii(0x1017_bff8, 5); calld(/* sys */ 0x1018_e594, 0x1_2597); /* call 0x1018e594 */
            ii(0x1017_bffd, 3); add(esp, 0x1c);                         /* add esp, 0x1c */
            ii(0x1017_c000, 5); jmpd(0x1017_ba97, -0x56e); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_c005:
            ii(0x1017_c005, 3); mov(dl, memb_a32[ss, ebp - 0xd]);       /* mov dl, [ebp-0xd] */
            ii(0x1017_c008, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_c00a, 3); cmp(dl, 0x3);                           /* cmp dl, 0x3 */
            ii(0x1017_c00d, 2); if(jaed(0x1017_c019, 0xa)) goto l_0x1017_c019; /* jae 0x1017c019 */
            ii(0x1017_c00f, 5); mov(edx, 0xffff_fff8);                  /* mov edx, 0xfffffff8 */
            ii(0x1017_c014, 5); jmpd(0x1017_baef, -0x52a); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_c019:
            ii(0x1017_c019, 4); test(memb_a32[ds, esi + 0xc], 0x1);     /* test byte [esi+0xc], 0x1 */
            ii(0x1017_c01d, 2); if(jzd(0x1017_c037, 0x18)) goto l_0x1017_c037; /* jz 0x1017c037 */
            ii(0x1017_c01f, 6); mov(edx, memd_a32[ds, 0x1020_9cc8]);    /* mov edx, [0x10209cc8] */
            ii(0x1017_c025, 6); mov(ebx, memd_a32[ds, 0x1020_9cd8]);    /* mov ebx, [0x10209cd8] */
            ii(0x1017_c02b, 6); mov(memd_a32[ds, 0x1020_9cd8], edx);    /* mov [0x10209cd8], edx */
            ii(0x1017_c031, 6); mov(memd_a32[ds, 0x1020_9cc8], ebx);    /* mov [0x10209cc8], ebx */
        l_0x1017_c037:
            ii(0x1017_c037, 6); mov(edi, memd_a32[ds, 0x1020_9ccc]);    /* mov edi, [0x10209ccc] */
            ii(0x1017_c03d, 3); lea(edx, eax + 0xe);                    /* lea edx, [eax+0xe] */
            ii(0x1017_c040, 2); test(edi, edi);                         /* test edi, edi */
            ii(0x1017_c042, 2); if(jzd(0x1017_c088, 0x44)) goto l_0x1017_c088; /* jz 0x1017c088 */
            ii(0x1017_c044, 7); cmp(memd_a32[ds, 0x101b_e200], 0);      /* cmp dword [0x101be200], 0x0 */
            ii(0x1017_c04b, 2); if(jzd(0x1017_c057, 0xa)) goto l_0x1017_c057; /* jz 0x1017c057 */
            ii(0x1017_c04d, 5); mov(edx, 0xffff_fff8);                  /* mov edx, 0xfffffff8 */
            ii(0x1017_c052, 5); jmpd(0x1017_baef, -0x568); goto l_0x1017_baef; /* jmp 0x1017baef */
        l_0x1017_c057:
            ii(0x1017_c057, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c059, 4); mov(bx, memw_a32[ds, eax + 0xa]);       /* mov bx, [eax+0xa] */
            ii(0x1017_c05d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c05e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c060, 4); mov(bx, memw_a32[ds, eax + 0x8]);       /* mov bx, [eax+0x8] */
            ii(0x1017_c064, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c065, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c067, 4); mov(bx, memw_a32[ds, eax + 0x6]);       /* mov bx, [eax+0x6] */
            ii(0x1017_c06b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c06c, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1017_c070, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_c075, 1); pushd(eax);                             /* push eax */
            ii(0x1017_c076, 1); pushd(edx);                             /* push edx */
            ii(0x1017_c077, 3); mov(esi, memd_a32[ss, ebp - 0x14]);     /* mov esi, [ebp-0x14] */
            ii(0x1017_c07a, 1); pushd(esi);                             /* push esi */
            ii(0x1017_c07b, 5); calld(/* sys */ 0x1019_1444, 0x1_53c4); /* call 0x10191444 */
            ii(0x1017_c080, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1017_c083, 5); jmpd(0x1017_ba97, -0x5f1); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_c088:
            ii(0x1017_c088, 6); mov(ebx, memd_a32[ds, 0x101b_e200]);    /* mov ebx, [0x101be200] */
            ii(0x1017_c08e, 3); and(ebx, 0x3);                          /* and ebx, 0x3 */
            ii(0x1017_c091, 3); cmp(ebx, 0x1);                          /* cmp ebx, 0x1 */
            ii(0x1017_c094, 2); if(jnzd(0x1017_c0c7, 0x31)) goto l_0x1017_c0c7; /* jnz 0x1017c0c7 */
            ii(0x1017_c096, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c098, 4); mov(bx, memw_a32[ds, eax + 0xa]);       /* mov bx, [eax+0xa] */
            ii(0x1017_c09c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c09d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c09f, 4); mov(bx, memw_a32[ds, eax + 0x8]);       /* mov bx, [eax+0x8] */
            ii(0x1017_c0a3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0a4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c0a6, 4); mov(bx, memw_a32[ds, eax + 0x6]);       /* mov bx, [eax+0x6] */
            ii(0x1017_c0aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0ab, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1017_c0af, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_c0b4, 1); pushd(eax);                             /* push eax */
            ii(0x1017_c0b5, 1); pushd(edx);                             /* push edx */
            ii(0x1017_c0b6, 3); mov(ebx, memd_a32[ss, ebp - 0x14]);     /* mov ebx, [ebp-0x14] */
            ii(0x1017_c0b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0ba, 5); calld(/* sys */ 0x1019_02d4, 0x1_4215); /* call 0x101902d4 */
            ii(0x1017_c0bf, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1017_c0c2, 5); jmpd(0x1017_ba97, -0x630); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_c0c7:
            ii(0x1017_c0c7, 3); cmp(ebx, 0x2);                          /* cmp ebx, 0x2 */
            ii(0x1017_c0ca, 2); if(jnzd(0x1017_c0fd, 0x31)) goto l_0x1017_c0fd; /* jnz 0x1017c0fd */
            ii(0x1017_c0cc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c0ce, 4); mov(bx, memw_a32[ds, eax + 0xa]);       /* mov bx, [eax+0xa] */
            ii(0x1017_c0d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0d3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c0d5, 4); mov(bx, memw_a32[ds, eax + 0x8]);       /* mov bx, [eax+0x8] */
            ii(0x1017_c0d9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0da, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c0dc, 4); mov(bx, memw_a32[ds, eax + 0x6]);       /* mov bx, [eax+0x6] */
            ii(0x1017_c0e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c0e1, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1017_c0e5, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_c0ea, 1); pushd(eax);                             /* push eax */
            ii(0x1017_c0eb, 1); pushd(edx);                             /* push edx */
            ii(0x1017_c0ec, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1017_c0ef, 1); pushd(edx);                             /* push edx */
            ii(0x1017_c0f0, 5); calld(/* sys */ 0x1019_02d4, 0x1_41df); /* call 0x101902d4 */
            ii(0x1017_c0f5, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1017_c0f8, 5); jmpd(0x1017_ba97, -0x666); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_c0fd:
            ii(0x1017_c0fd, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c0ff, 4); mov(bx, memw_a32[ds, eax + 0xa]);       /* mov bx, [eax+0xa] */
            ii(0x1017_c103, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c104, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c106, 4); mov(bx, memw_a32[ds, eax + 0x8]);       /* mov bx, [eax+0x8] */
            ii(0x1017_c10a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c10b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c10d, 4); mov(bx, memw_a32[ds, eax + 0x6]);       /* mov bx, [eax+0x6] */
            ii(0x1017_c111, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_c112, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x1017_c116, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1017_c11b, 1); pushd(eax);                             /* push eax */
            ii(0x1017_c11c, 1); pushd(edx);                             /* push edx */
            ii(0x1017_c11d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1017_c120, 1); pushd(eax);                             /* push eax */
            ii(0x1017_c121, 5); calld(/* sys */ 0x1018_e840, 0x1_271a); /* call 0x1018e840 */
            ii(0x1017_c126, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x1017_c129, 5); jmpd(0x1017_ba97, -0x697); goto l_0x1017_ba97; /* jmp 0x1017ba97 */
        l_0x1017_c12e:
            ii(0x1017_c12e, 5); calld(/* sys */ 0x1017_99b0, -0x2783);  /* call 0x101799b0 */
            ii(0x1017_c133, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_c135, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1017_c138, 3); mov(memd_a32[ss, ebp - 0x18], ebx);     /* mov [ebp-0x18], ebx */
            ii(0x1017_c13b, 5); jmpd(0x1017_ba7e, -0x6c2); goto l_0x1017_ba7e; /* jmp 0x1017ba7e */
        }
    }
}
