using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_d1cc-58995e93")]
        public void Method_100f_d1cc()
        {
            ii(0x100f_d1cc, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x100f_d1d1, 5); calld(Definitions.sys_check_available_stack_size, 0x6_8b7c); /* call 0x10165d52 */
            ii(0x100f_d1d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_d1d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_d1d8, 1); pushd(edx);                             /* push edx */
            ii(0x100f_d1d9, 1); pushd(esi);                             /* push esi */
            ii(0x100f_d1da, 1); pushd(edi);                             /* push edi */
            ii(0x100f_d1db, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_d1dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_d1de, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100f_d1e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_d1e7, 7); mov(memd_a32[ss, ebp - 0x20], 0x2);     /* mov dword [ebp-0x20], 0x2 */
        l_0x100f_d1ee:
            ii(0x100f_d1ee, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d1f1, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x100f_d1f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d1f7, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
            ii(0x100f_d1fb, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_d202, 2); jmpd(0x100f_d208, 0x4); goto l_0x100f_d208; /* jmp 0x100fd208 */
        l_0x100f_d204:
            ii(0x100f_d204, 4); add(memd_a32[ss, ebp - 0x14], 0x2);     /* add dword [ebp-0x14], 0x2 */
        l_0x100f_d208:
            ii(0x100f_d208, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_d20c, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_d20f, 6); if(jged(0x100f_d395, 0x180)) goto l_0x100f_d395; /* jge 0x100fd395 */
            ii(0x100f_d215, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100f_d21c, 2); jmpd(0x100f_d224, 0x6); goto l_0x100f_d224; /* jmp 0x100fd224 */
        l_0x100f_d21e:
            ii(0x100f_d21e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_d221, 3); inc(memd_a32[ss, ebp - 0x1c]);          /* inc dword [ebp-0x1c] */
        l_0x100f_d224:
            ii(0x100f_d224, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100f_d227, 4); cmp(ax, memw_a32[ss, ebp - 0x20]);      /* cmp ax, [ebp-0x20] */
            ii(0x100f_d22b, 6); if(jged(0x100f_d390, 0x15f)) goto l_0x100f_d390; /* jge 0x100fd390 */
            ii(0x100f_d231, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_d235, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_d238, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100f_d23d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_d23f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d242, 5); calld(0x1008_b1a4, -0x7_20a3);          /* call 0x1008b1a4 */
            ii(0x100f_d247, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d24a, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_d24d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_d250, 2); if(jld(0x100f_d25f, 0xd)) goto l_0x100f_d25f; /* jl 0x100fd25f */
            ii(0x100f_d252, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d255, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_d257, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d25a, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100f_d25d, 2); if(jged(0x100f_d261, 0x2)) goto l_0x100f_d261; /* jge 0x100fd261 */
        l_0x100f_d25f:
            ii(0x100f_d25f, 2); jmpd(0x100f_d277, 0x16); goto l_0x100f_d277; /* jmp 0x100fd277 */
        l_0x100f_d261:
            ii(0x100f_d261, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d264, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_d267, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100f_d26d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_d270, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_d273, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_d275, 2); if(jld(0x100f_d279, 0x2)) goto l_0x100f_d279; /* jl 0x100fd279 */
        l_0x100f_d277:
            ii(0x100f_d277, 2); jmpd(0x100f_d291, 0x18); goto l_0x100f_d291; /* jmp 0x100fd291 */
        l_0x100f_d279:
            ii(0x100f_d279, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d27c, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_d27e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d281, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100f_d287, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_d28a, 3); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_d28d, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100f_d28f, 2); if(jld(0x100f_d296, 0x5)) goto l_0x100f_d296; /* jl 0x100fd296 */
        l_0x100f_d291:
            ii(0x100f_d291, 5); jmpd(0x100f_d38b, 0xf5); goto l_0x100f_d38b; /* jmp 0x100fd38b */
        l_0x100f_d296:
            ii(0x100f_d296, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x100f_d29a, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100f_d2a1, 2); jmpd(0x100f_d2a9, 0x6); goto l_0x100f_d2a9; /* jmp 0x100fd2a9 */
        l_0x100f_d2a3:
            ii(0x100f_d2a3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_d2a6, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x100f_d2a9:
            ii(0x100f_d2a9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_d2ad, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100f_d2b0, 2); if(jged(0x100f_d30f, 0x5d)) goto l_0x100f_d30f; /* jge 0x100fd30f */
            ii(0x100f_d2b2, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_d2b6, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100f_d2bc, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100f_d2c2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_d2c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d2c9, 2); if(jzd(0x100f_d307, 0x3c)) goto l_0x100f_d307; /* jz 0x100fd307 */
            ii(0x100f_d2cb, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_d2cf, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_d2d2, 7); mov(ax, memw_a32[ds, eax + 0x101c_35be]); /* mov ax, [eax+0x101c35be] */
            ii(0x100f_d2d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_d2dc, 4); sub(ax, memw_a32[ds, edx + 0x2]);       /* sub ax, [edx+0x2] */
            ii(0x100f_d2e0, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100f_d2e3, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_d2e7, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x100f_d2ea, 7); mov(ax, memw_a32[ds, eax + 0x101c_35bc]); /* mov ax, [eax+0x101c35bc] */
            ii(0x100f_d2f1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_d2f4, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_d2f7, 1); cwde();                                 /* cwde */
            ii(0x100f_d2f8, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100f_d2fa, 5); calld(0x1007_0c16, -0x8_c6e9);          /* call 0x10070c16 */
            ii(0x100f_d2ff, 1); cwde();                                 /* cwde */
            ii(0x100f_d300, 5); cmp(eax, 0x100);                        /* cmp eax, 0x100 */
            ii(0x100f_d305, 2); if(jld(0x100f_d309, 0x2)) goto l_0x100f_d309; /* jl 0x100fd309 */
        l_0x100f_d307:
            ii(0x100f_d307, 2); jmpd(0x100f_d30d, 0x4); goto l_0x100f_d30d; /* jmp 0x100fd30d */
        l_0x100f_d309:
            ii(0x100f_d309, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_d30d:
            ii(0x100f_d30d, 2); jmpd(0x100f_d2a3, -0x6c); goto l_0x100f_d2a3; /* jmp 0x100fd2a3 */
        l_0x100f_d30f:
            ii(0x100f_d30f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d312, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_d315, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_d318, 2); jmpd(0x100f_d320, 0x6); goto l_0x100f_d320; /* jmp 0x100fd320 */
        l_0x100f_d31a:
            ii(0x100f_d31a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_d31d, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100f_d320:
            ii(0x100f_d320, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d323, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100f_d326, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_d32a, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_d32d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_d32f, 2); if(jged(0x100f_d337, 0x6)) goto l_0x100f_d337; /* jge 0x100fd337 */
            ii(0x100f_d331, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_d335, 2); if(jnzd(0x100f_d339, 0x2)) goto l_0x100f_d339; /* jnz 0x100fd339 */
        l_0x100f_d337:
            ii(0x100f_d337, 2); jmpd(0x100f_d385, 0x4c); goto l_0x100f_d385; /* jmp 0x100fd385 */
        l_0x100f_d339:
            ii(0x100f_d339, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d33c, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100f_d340, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_d343, 2); jmpd(0x100f_d34b, 0x6); goto l_0x100f_d34b; /* jmp 0x100fd34b */
        l_0x100f_d345:
            ii(0x100f_d345, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_d348, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100f_d34b:
            ii(0x100f_d34b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_d34e, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100f_d350, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d353, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_d357, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_d35a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_d35c, 2); if(jged(0x100f_d364, 0x6)) goto l_0x100f_d364; /* jge 0x100fd364 */
            ii(0x100f_d35e, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_d362, 2); if(jnzd(0x100f_d366, 0x2)) goto l_0x100f_d366; /* jnz 0x100fd366 */
        l_0x100f_d364:
            ii(0x100f_d364, 2); jmpd(0x100f_d383, 0x1d); goto l_0x100f_d383; /* jmp 0x100fd383 */
        l_0x100f_d366:
            ii(0x100f_d366, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100f_d36a, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_d36e, 5); calld(0x1007_3d48, -0x8_962b);          /* call 0x10073d48 */
            ii(0x100f_d373, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_d378, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_d37b, 2); if(jnzd(0x100f_d381, 0x4)) goto l_0x100f_d381; /* jnz 0x100fd381 */
            ii(0x100f_d37d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x100f_d381:
            ii(0x100f_d381, 2); jmpd(0x100f_d345, -0x3e); goto l_0x100f_d345; /* jmp 0x100fd345 */
        l_0x100f_d383:
            ii(0x100f_d383, 2); jmpd(0x100f_d31a, -0x6b); goto l_0x100f_d31a; /* jmp 0x100fd31a */
        l_0x100f_d385:
            ii(0x100f_d385, 4); cmp(memb_a32[ss, ebp - 0x8], 0);        /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100f_d389, 2); if(jnzd(0x100f_d39e, 0x13)) goto l_0x100f_d39e; /* jnz 0x100fd39e */
        l_0x100f_d38b:
            ii(0x100f_d38b, 5); jmpd(0x100f_d21e, -0x172); goto l_0x100f_d21e; /* jmp 0x100fd21e */
        l_0x100f_d390:
            ii(0x100f_d390, 5); jmpd(0x100f_d204, -0x191); goto l_0x100f_d204; /* jmp 0x100fd204 */
        l_0x100f_d395:
            ii(0x100f_d395, 4); add(memd_a32[ss, ebp - 0x20], 0x2);     /* add dword [ebp-0x20], 0x2 */
            ii(0x100f_d399, 5); jmpd(0x100f_d1ee, -0x1b0); goto l_0x100f_d1ee; /* jmp 0x100fd1ee */
        l_0x100f_d39e:
            ii(0x100f_d39e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_d3a0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_d3a1, 1); popd(edi);                              /* pop edi */
            ii(0x100f_d3a2, 1); popd(esi);                              /* pop esi */
            ii(0x100f_d3a3, 1); popd(edx);                              /* pop edx */
            ii(0x100f_d3a4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_d3a5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_d3a6, 1); retd();                                 /* ret */
        }
    }
}
