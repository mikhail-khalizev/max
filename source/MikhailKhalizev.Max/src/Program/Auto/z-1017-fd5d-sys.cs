using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_fd5d-250f7eb9")]
        public void /* sys */ Method_1017_fd5d()
        {
            ii(0x1017_fd5d, 1); push(edx);                              /* push edx */
            ii(0x1017_fd5e, 1); push(esi);                              /* push esi */
            ii(0x1017_fd5f, 1); push(edi);                              /* push edi */
            ii(0x1017_fd60, 1); push(ebp);                              /* push ebp */
            ii(0x1017_fd61, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_fd63, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1017_fd69, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1017_fd6c, 4); mov(memw[ss, ebp - 0x1c], cx);          /* mov [ebp-0x1c], cx */
            ii(0x1017_fd70, 3); mov(memd[ss, ebp - 0x20], ebx);         /* mov [ebp-0x20], ebx */
            ii(0x1017_fd73, 4); imul(edx, memd[ss, ebp - 0x10], 0x6);   /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1017_fd77, 7); mov(ax, memw[ds, edx + 0x101c_0214]);   /* mov ax, [edx+0x101c0214] */
            ii(0x1017_fd7e, 4); mov(memw[ss, ebp - 0x24], ax);          /* mov [ebp-0x24], ax */
            ii(0x1017_fd82, 6); mov(eax, memd[ds, edx + 0x101c_0210]);  /* mov eax, [edx+0x101c0210] */
            ii(0x1017_fd88, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1017_fd8b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_fd8e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_fd91, 10); cmp(memd[ds, eax + 0x101c_035a], 0xe106); /* cmp dword [eax+0x101c035a], 0xe106 */
            ii(0x1017_fd9b, 2); if(jb(0x1017_fdc4, 0x27)) goto l_0x1017_fdc4; /* jb 0x1017fdc4 */
            ii(0x1017_fd9d, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_fda1, 5); mov(ax, memw[gs, eax + 0x4]);           /* mov ax, [gs:eax+0x4] */
            ii(0x1017_fda6, 4); mov(memw[ss, ebp - 0x14], ax);          /* mov [ebp-0x14], ax */
            ii(0x1017_fdaa, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_fdae, 3); mov(eax, memd[gs, eax]);                /* mov eax, [gs:eax] */
            ii(0x1017_fdb1, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1017_fdb4, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_fdb8, 4); mov(eax, memd[gs, eax + 0x8]);          /* mov eax, [gs:eax+0x8] */
            ii(0x1017_fdbc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1017_fdbf, 5); jmp(0x1018_0367, 0x5a3); goto l_0x1018_0367; /* jmp 0x10180367 */
        l_0x1017_fdc4:
            ii(0x1017_fdc4, 7); mov(memd[ss, ebp - 0x4], 0);            /* mov dword [ebp-0x4], 0x0 */
        l_0x1017_fdcb:
            ii(0x1017_fdcb, 4); cmp(memd[ss, ebp - 0x4], 0x20);         /* cmp dword [ebp-0x4], 0x20 */
            ii(0x1017_fdcf, 2); if(jb(0x1017_fddb, 0xa)) goto l_0x1017_fddb; /* jb 0x1017fddb */
            ii(0x1017_fdd1, 5); jmp(0x1018_035e, 0x588); goto l_0x1018_035e; /* jmp 0x1018035e */
        l_0x1017_fdd6:
            ii(0x1017_fdd6, 3); inc(memd[ss, ebp - 0x4]);               /* inc dword [ebp-0x4] */
            ii(0x1017_fdd9, 2); jmp(0x1017_fdcb, -0x10); goto l_0x1017_fdcb; /* jmp 0x1017fdcb */
        l_0x1017_fddb:
            ii(0x1017_fddb, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_fde2, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_fde6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fde8, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1017_fdef, 5); movsx(eax, memw[gs, eax + 0x30]);       /* movsx eax, word [gs:eax+0x30] */
            ii(0x1017_fdf4, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x1017_fdf7, 6); if(jnz(0x1018_0359, 0x55c)) goto l_0x1018_0359; /* jnz 0x10180359 */
            ii(0x1017_fdfd, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1017_fe04, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1017_fe08, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fe0a, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_fe11, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_fe15, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_fe1b, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_fe1f, 5); mov(dx, memw[gs, edx + 0x4]);           /* mov dx, [gs:edx+0x4] */
            ii(0x1017_fe24, 4); lgs(ebx, memd[ss, ebp - 0x20]);         /* lgs ebx, [ebp-0x20] */
            ii(0x1017_fe28, 3); mov(ebx, memd[gs, ebx]);                /* mov ebx, [gs:ebx] */
            ii(0x1017_fe2b, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_fe2e, 5); mov(memw[gs, eax + 0x4], dx);           /* mov [gs:eax+0x4], dx */
            ii(0x1017_fe33, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_fe36, 3); mov(memd[gs, eax], ebx);                /* mov [gs:eax], ebx */
            ii(0x1017_fe39, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_fe40, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_fe44, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fe46, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_fe4d, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_fe51, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_fe57, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_fe5b, 5); mov(dx, memw[gs, edx + 0x4]);           /* mov dx, [gs:edx+0x4] */
            ii(0x1017_fe60, 4); lgs(ebx, memd[ss, ebp - 0x20]);         /* lgs ebx, [ebp-0x20] */
            ii(0x1017_fe64, 3); mov(ebx, memd[gs, ebx]);                /* mov ebx, [gs:ebx] */
            ii(0x1017_fe67, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_fe6a, 5); mov(memw[gs, eax + 0xc], dx);           /* mov [gs:eax+0xc], dx */
            ii(0x1017_fe6f, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_fe72, 4); mov(memd[gs, eax + 0x8], ebx);          /* mov [gs:eax+0x8], ebx */
            ii(0x1017_fe76, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_fe7a, 5); mov(ax, memw[gs, eax + 0x4]);           /* mov ax, [gs:eax+0x4] */
            ii(0x1017_fe7f, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_fe83, 3); mov(edx, memd[gs, edx]);                /* mov edx, [gs:edx] */
            ii(0x1017_fe86, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_fe88, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_fe8c, 4); add(edx, memd[gs, eax + 0x30]);         /* add edx, [gs:eax+0x30] */
            ii(0x1017_fe90, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_fe92, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_fe94, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_fe96, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_fe9d, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_fea1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fea3, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1017_feaa, 5); mov(memw[gs, eax + 0x14], bx);          /* mov [gs:eax+0x14], bx */
            ii(0x1017_feaf, 4); mov(memd[gs, eax + 0x10], ecx);         /* mov [gs:eax+0x10], ecx */
            ii(0x1017_feb3, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_feb7, 5); test(memb[gs, eax + 0x28], 0x40);       /* test byte [gs:eax+0x28], 0x40 */
            ii(0x1017_febc, 6); if(jz(0x1017_ff7d, 0xbb)) goto l_0x1017_ff7d; /* jz 0x1017ff7d */
            ii(0x1017_fec2, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1017_fec9, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1017_fecd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fecf, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_fed6, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_feda, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_fee0, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_fee4, 4); mov(edx, memd[gs, edx + 0x30]);         /* mov edx, [gs:edx+0x30] */
            ii(0x1017_fee8, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_feeb, 4); mov(memd[gs, eax + 0x18], edx);         /* mov [gs:eax+0x18], edx */
            ii(0x1017_feef, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_fef6, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_fefa, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_fefc, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_ff03, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_ff07, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_ff0d, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ff11, 4); mov(edx, memd[gs, edx + 0x30]);         /* mov edx, [gs:edx+0x30] */
            ii(0x1017_ff15, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_ff18, 4); mov(memd[gs, eax + 0x1c], edx);         /* mov [gs:eax+0x1c], edx */
            ii(0x1017_ff1c, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_ff23, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_ff27, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_ff29, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_ff30, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_ff34, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_ff3a, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ff3e, 4); mov(edx, memd[gs, edx + 0x34]);         /* mov edx, [gs:edx+0x34] */
            ii(0x1017_ff42, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_ff45, 4); mov(memd[gs, eax + 0x20], edx);         /* mov [gs:eax+0x20], edx */
            ii(0x1017_ff49, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1017_ff4d, 4); mov(eax, memd[gs, eax + 0x30]);         /* mov eax, [gs:eax+0x30] */
            ii(0x1017_ff51, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ff55, 4); add(eax, memd[gs, edx + 0x34]);         /* add eax, [gs:edx+0x34] */
            ii(0x1017_ff59, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ff5d, 4); mov(edx, memd[gs, edx + 0x2c]);         /* mov edx, [gs:edx+0x2c] */
            ii(0x1017_ff61, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1017_ff63, 7); imul(ebx, memd[ss, ebp - 0x10], 0xc0);  /* imul ebx, [ebp-0x10], 0xc0 */
            ii(0x1017_ff6a, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_ff6e, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1017_ff70, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1017_ff77, 4); mov(memd[gs, eax + 0x2c], edx);         /* mov [gs:eax+0x2c], edx */
            ii(0x1017_ff7b, 2); jmp(0x1017_ffd7, 0x5a); goto l_0x1017_ffd7; /* jmp 0x1017ffd7 */
        l_0x1017_ff7d:
            ii(0x1017_ff7d, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1017_ff84, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1017_ff88, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_ff8a, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_ff91, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_ff95, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_ff9b, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ff9f, 4); mov(edx, memd[gs, edx + 0x8]);          /* mov edx, [gs:edx+0x8] */
            ii(0x1017_ffa3, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_ffa6, 4); mov(memd[gs, eax + 0x18], edx);         /* mov [gs:eax+0x18], edx */
            ii(0x1017_ffaa, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1017_ffb1, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1017_ffb5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_ffb7, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_ffbe, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_ffc2, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_ffc8, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_ffcc, 4); mov(edx, memd[gs, edx + 0x8]);          /* mov edx, [gs:edx+0x8] */
            ii(0x1017_ffd0, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1017_ffd3, 4); mov(memd[gs, eax + 0x1c], edx);         /* mov [gs:eax+0x1c], edx */
        l_0x1017_ffd7:
            ii(0x1017_ffd7, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1017_ffde, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1017_ffe2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1017_ffe4, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1017_ffeb, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1017_ffef, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1017_fff5, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1017_fff9, 5); mov(dx, memw[gs, edx + 0x14]);          /* mov dx, [gs:edx+0x14] */
            ii(0x1017_fffe, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0001, 5); mov(memw[gs, eax + 0x32], dx);          /* mov [gs:eax+0x32], dx */
            ii(0x1018_0006, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_000d, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1018_0011, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0013, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_001a, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_001e, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0024, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0028, 5); mov(dx, memw[gs, edx + 0x18]);          /* mov dx, [gs:edx+0x18] */
            ii(0x1018_002d, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0030, 5); mov(memw[gs, eax + 0x34], dx);          /* mov [gs:eax+0x34], dx */
            ii(0x1018_0035, 4); lgs(eax, memd[ss, ebp - 0x20]);         /* lgs eax, [ebp-0x20] */
            ii(0x1018_0039, 5); mov(bx, memw[gs, eax + 0x28]);          /* mov bx, [gs:eax+0x28] */
            ii(0x1018_003e, 3); or(bh, 0xa0);                           /* or bh, 0xa0 */
            ii(0x1018_0041, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0048, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_004c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_004e, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0055, 5); mov(memw[gs, eax + 0x30], bx);          /* mov [gs:eax+0x30], bx */
            ii(0x1018_005a, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_0061, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1018_0065, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0067, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_006e, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0072, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0078, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_007c, 5); mov(dx, memw[gs, edx + 0x10]);          /* mov dx, [gs:edx+0x10] */
            ii(0x1018_0081, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0084, 5); mov(memw[gs, eax + 0x36], dx);          /* mov [gs:eax+0x36], dx */
            ii(0x1018_0089, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0090, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0094, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0096, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_009d, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_00a1, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_00a7, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_00ab, 5); mov(dx, memw[gs, edx + 0x20]);          /* mov dx, [gs:edx+0x20] */
            ii(0x1018_00b0, 4); lgs(ebx, memd[ss, ebp - 0x20]);         /* lgs ebx, [ebp-0x20] */
            ii(0x1018_00b4, 4); mov(ebx, memd[gs, ebx + 0x1c]);         /* mov ebx, [gs:ebx+0x1c] */
            ii(0x1018_00b8, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_00bb, 5); mov(memw[gs, eax + 0x40], dx);          /* mov [gs:eax+0x40], dx */
            ii(0x1018_00c0, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_00c3, 4); mov(memd[gs, eax + 0x3c], ebx);         /* mov [gs:eax+0x3c], ebx */
            ii(0x1018_00c7, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_00ce, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1018_00d2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_00d4, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_00db, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_00df, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_00e5, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_00e9, 5); mov(dx, memw[gs, edx + 0xc]);           /* mov dx, [gs:edx+0xc] */
            ii(0x1018_00ee, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_00f1, 5); mov(memw[gs, eax + 0x38], dx);          /* mov [gs:eax+0x38], dx */
            ii(0x1018_00f6, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_00fd, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0101, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0103, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_010a, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_010e, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0114, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0118, 5); mov(dx, memw[gs, edx + 0x24]);          /* mov dx, [gs:edx+0x24] */
            ii(0x1018_011d, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0120, 5); mov(memw[gs, eax + 0x4a], dx);          /* mov [gs:eax+0x4a], dx */
            ii(0x1018_0125, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_012c, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0130, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0132, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0139, 7); mov(memw[gs, eax + 0x3a], 0);           /* mov word [gs:eax+0x3a], 0x0 */
            ii(0x1018_0140, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0147, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_014b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_014d, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0154, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0158, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_015e, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0162, 4); mov(edx, memd[gs, edx + 0x38]);         /* mov edx, [gs:edx+0x38] */
            ii(0x1018_0166, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0169, 4); mov(memd[gs, eax + 0x44], edx);         /* mov [gs:eax+0x44], edx */
            ii(0x1018_016d, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_0174, 4); imul(edx, memd[ss, ebp - 0x4], 0x6);    /* imul edx, [ebp-0x4], 0x6 */
            ii(0x1018_0178, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_017a, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0181, 7); mov(memw[gs, eax + 0x48], 0);           /* mov word [gs:eax+0x48], 0x0 */
            ii(0x1018_0188, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_018f, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0193, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0195, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_019c, 8); mov(memd[gs, eax + 0x4c], 0);           /* mov dword [gs:eax+0x4c], 0x0 */
            ii(0x1018_01a4, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_01ab, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_01af, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_01b1, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_01b8, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_01bc, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_01c2, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_01c6, 4); mov(edx, memd[gs, edx + 0x8]);          /* mov edx, [gs:edx+0x8] */
            ii(0x1018_01ca, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_01cd, 4); mov(memd[gs, eax + 0x50], edx);         /* mov [gs:eax+0x50], edx */
            ii(0x1018_01d1, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_01d8, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_01dc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_01de, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_01e5, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_01e9, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_01ef, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_01f3, 5); mov(dx, memw[gs, edx + 0x40]);          /* mov dx, [gs:edx+0x40] */
            ii(0x1018_01f8, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_01fb, 5); mov(memw[gs, eax + 0x54], dx);          /* mov [gs:eax+0x54], dx */
            ii(0x1018_0200, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0207, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_020b, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_020d, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0214, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0218, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_021e, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0222, 5); mov(dx, memw[gs, edx + 0x44]);          /* mov dx, [gs:edx+0x44] */
            ii(0x1018_0227, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_022a, 5); mov(memw[gs, eax + 0x56], dx);          /* mov [gs:eax+0x56], dx */
            ii(0x1018_022f, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0236, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_023a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_023c, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0243, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0247, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_024d, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0251, 5); mov(dx, memw[gs, edx + 0x48]);          /* mov dx, [gs:edx+0x48] */
            ii(0x1018_0256, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0259, 5); mov(memw[gs, eax + 0x58], dx);          /* mov [gs:eax+0x58], dx */
            ii(0x1018_025e, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0265, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0269, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_026b, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0272, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0276, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_027c, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_0280, 5); mov(dx, memw[gs, edx + 0x4c]);          /* mov dx, [gs:edx+0x4c] */
            ii(0x1018_0285, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0288, 5); mov(memw[gs, eax + 0x5a], dx);          /* mov [gs:eax+0x5a], dx */
            ii(0x1018_028d, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0294, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0298, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_029a, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_02a1, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_02a5, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_02ab, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_02af, 5); mov(dx, memw[gs, edx + 0x50]);          /* mov dx, [gs:edx+0x50] */
            ii(0x1018_02b4, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_02b7, 5); mov(memw[gs, eax + 0x5c], dx);          /* mov [gs:eax+0x5c], dx */
            ii(0x1018_02bc, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_02c3, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_02c7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_02c9, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_02d0, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_02d4, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_02da, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_02de, 5); mov(dx, memw[gs, edx + 0x54]);          /* mov dx, [gs:edx+0x54] */
            ii(0x1018_02e3, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_02e6, 5); mov(memw[gs, eax + 0x5e], dx);          /* mov [gs:eax+0x5e], dx */
            ii(0x1018_02eb, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_02f2, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_02f6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_02f8, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_02ff, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0303, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0309, 4); lgs(edx, memd[ss, ebp - 0x20]);         /* lgs edx, [ebp-0x20] */
            ii(0x1018_030d, 5); mov(dx, memw[gs, edx + 0x58]);          /* mov dx, [gs:edx+0x58] */
            ii(0x1018_0312, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0315, 5); mov(memw[gs, eax + 0x60], dx);          /* mov [gs:eax+0x60], dx */
            ii(0x1018_031a, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0321, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0325, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0327, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_032e, 8); mov(memd[gs, eax + 0x64], 0);           /* mov dword [gs:eax+0x64], 0x0 */
            ii(0x1018_0336, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_033d, 4); imul(eax, memd[ss, ebp - 0x4], 0x6);    /* imul eax, [ebp-0x4], 0x6 */
            ii(0x1018_0341, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0343, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_034a, 7); mov(memw[gs, eax + 0x68], 0);           /* mov word [gs:eax+0x68], 0x0 */
            ii(0x1018_0351, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1018_0354, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1018_0357, 2); jmp(0x1018_036e, 0x15); goto l_0x1018_036e; /* jmp 0x1018036e */
        l_0x1018_0359:
            ii(0x1018_0359, 5); jmp(0x1017_fdd6, -0x588); goto l_0x1017_fdd6; /* jmp 0x1017fdd6 */
        l_0x1018_035e:
            ii(0x1018_035e, 7); mov(memd[ss, ebp - 0x8], 0xffff_ffff);  /* mov dword [ebp-0x8], 0xffffffff */
            ii(0x1018_0365, 2); jmp(0x1018_036e, 0x7); goto l_0x1018_036e; /* jmp 0x1018036e */
        l_0x1018_0367:
            ii(0x1018_0367, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1018_036e:
            ii(0x1018_036e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1018_0371, 1); leave();                                /* leave */
            ii(0x1018_0372, 1); pop(edi);                               /* pop edi */
            ii(0x1018_0373, 1); pop(esi);                               /* pop esi */
            ii(0x1018_0374, 1); pop(edx);                               /* pop edx */
            ii(0x1018_0375, 1); ret();                                  /* ret */
        }
    }
}
