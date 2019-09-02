using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_03dc-34c3a3ae")]
        public void /* sys */ Method_1018_03dc()
        {
            ii(0x1018_03dc, 1); push(esi);                              /* push esi */
            ii(0x1018_03dd, 1); push(edi);                              /* push edi */
            ii(0x1018_03de, 1); push(ebp);                              /* push ebp */
            ii(0x1018_03df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_03e1, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1018_03e7, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1018_03ea, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1018_03ed, 4); mov(memw[ss, ebp - 0x14], cx);          /* mov [ebp-0x14], cx */
            ii(0x1018_03f1, 3); mov(memd[ss, ebp - 0x18], ebx);         /* mov [ebp-0x18], ebx */
            ii(0x1018_03f4, 4); imul(edx, memd[ss, ebp - 0x10], 6);     /* imul edx, [ebp-0x10], 0x6 */
            ii(0x1018_03f8, 7); mov(ax, memw[ds, edx + 0x101c_0214]);   /* mov ax, [edx+0x101c0214] */
            ii(0x1018_03ff, 4); mov(memw[ss, ebp - 0x1c], ax);          /* mov [ebp-0x1c], ax */
            ii(0x1018_0403, 6); mov(eax, memd[ds, edx + 0x101c_0210]);  /* mov eax, [edx+0x101c0210] */
            ii(0x1018_0409, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1018_040c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1018_040f, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1018_0412, 10); cmp(memd[ds, eax + 0x101c_035a], 0xe106); /* cmp dword [eax+0x101c035a], 0xe106 */
            ii(0x1018_041c, 2); if(jb(0x1018_0445, 0x27)) goto l_0x1018_0445; /* jb 0x10180445 */
            ii(0x1018_041e, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_0422, 5); mov(ax, memw[gs, eax + 4]);             /* mov ax, [gs:eax+0x4] */
            ii(0x1018_0427, 4); mov(memw[ss, ebp - 0x24], ax);          /* mov [ebp-0x24], ax */
            ii(0x1018_042b, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_042f, 3); mov(eax, memd[gs, eax]);                /* mov eax, [gs:eax] */
            ii(0x1018_0432, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x1018_0435, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_0439, 4); mov(eax, memd[gs, eax + 8]);            /* mov eax, [gs:eax+0x8] */
            ii(0x1018_043d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1018_0440, 5); jmp(0x1018_0743, 0x2fe); goto l_0x1018_0743; /* jmp 0x10180743 */
        l_0x1018_0445:
            ii(0x1018_0445, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_044c, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0450, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_0452, 7); mov(ax, memw[ds, edx + 0x1020_b71c]);   /* mov ax, [edx+0x1020b71c] */
            ii(0x1018_0459, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1018_045d, 6); mov(edx, memd[ds, edx + 0x1020_b718]);  /* mov edx, [edx+0x1020b718] */
            ii(0x1018_0463, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_0467, 5); mov(ax, memw[gs, eax + 4]);             /* mov ax, [gs:eax+0x4] */
            ii(0x1018_046c, 4); lgs(ebx, memd[ss, ebp - 0x18]);         /* lgs ebx, [ebp-0x18] */
            ii(0x1018_0470, 3); mov(ebx, memd[gs, ebx]);                /* mov ebx, [gs:ebx] */
            ii(0x1018_0473, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0476, 5); mov(memw[gs, edx + 4], ax);             /* mov [gs:edx+0x4], ax */
            ii(0x1018_047b, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_047e, 3); mov(memd[gs, edx], ebx);                /* mov [gs:edx], ebx */
            ii(0x1018_0481, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0488, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_048c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_048e, 7); mov(ax, memw[ds, edx + 0x1020_b71c]);   /* mov ax, [edx+0x1020b71c] */
            ii(0x1018_0495, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1018_0499, 6); mov(edx, memd[ds, edx + 0x1020_b718]);  /* mov edx, [edx+0x1020b718] */
            ii(0x1018_049f, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_04a3, 5); mov(ax, memw[gs, eax + 4]);             /* mov ax, [gs:eax+0x4] */
            ii(0x1018_04a8, 4); lgs(ebx, memd[ss, ebp - 0x18]);         /* lgs ebx, [ebp-0x18] */
            ii(0x1018_04ac, 3); mov(ebx, memd[gs, ebx]);                /* mov ebx, [gs:ebx] */
            ii(0x1018_04af, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_04b2, 5); mov(memw[gs, edx + 0xc], ax);           /* mov [gs:edx+0xc], ax */
            ii(0x1018_04b7, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_04ba, 4); mov(memd[gs, edx + 8], ebx);            /* mov [gs:edx+0x8], ebx */
            ii(0x1018_04be, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_04c2, 5); mov(ax, memw[gs, eax + 4]);             /* mov ax, [gs:eax+0x4] */
            ii(0x1018_04c7, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_04cb, 3); mov(edx, memd[gs, edx]);                /* mov edx, [gs:edx] */
            ii(0x1018_04ce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_04d0, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_04d4, 4); add(edx, memd[gs, eax + 0x30]);         /* add edx, [gs:eax+0x30] */
            ii(0x1018_04d8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_04da, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_04dc, 7); imul(ecx, memd[ss, ebp - 0x10], 0xc0);  /* imul ecx, [ebp-0x10], 0xc0 */
            ii(0x1018_04e3, 4); imul(edx, memd[ss, ebp - 0xc], 6);      /* imul edx, [ebp-0xc], 0x6 */
            ii(0x1018_04e7, 2); add(edx, ecx);                          /* add edx, ecx */
            ii(0x1018_04e9, 7); lgs(edx, memd[ds, edx + 0x1020_b718]);  /* lgs edx, [edx+0x1020b718] */
            ii(0x1018_04f0, 5); mov(memw[gs, edx + 0x14], ax);          /* mov [gs:edx+0x14], ax */
            ii(0x1018_04f5, 4); mov(memd[gs, edx + 0x10], ebx);         /* mov [gs:edx+0x10], ebx */
            ii(0x1018_04f9, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_0500, 4); imul(edx, memd[ss, ebp - 0xc], 6);      /* imul edx, [ebp-0xc], 0x6 */
            ii(0x1018_0504, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1018_0506, 7); mov(ax, memw[ds, edx + 0x1020_b71c]);   /* mov ax, [edx+0x1020b71c] */
            ii(0x1018_050d, 4); mov(memw[ss, ebp - 0x2c], ax);          /* mov [ebp-0x2c], ax */
            ii(0x1018_0511, 6); mov(edx, memd[ds, edx + 0x1020_b718]);  /* mov edx, [edx+0x1020b718] */
            ii(0x1018_0517, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_051b, 4); mov(eax, memd[gs, eax + 8]);            /* mov eax, [gs:eax+0x8] */
            ii(0x1018_051f, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0522, 4); mov(memd[gs, edx + 0x50], eax);         /* mov [gs:edx+0x50], eax */
            ii(0x1018_0526, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_052a, 5); test(memb[gs, eax + 0x28], 0x40);       /* test byte [gs:eax+0x28], 0x40 */
            ii(0x1018_052f, 6); if(jz(0x1018_05f0, 0xbb)) goto l_0x1018_05f0; /* jz 0x101805f0 */
            ii(0x1018_0535, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_053c, 4); imul(edx, memd[ss, ebp - 0xc], 6);      /* imul edx, [ebp-0xc], 0x6 */
            ii(0x1018_0540, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0542, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0549, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_054d, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0553, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_0557, 4); mov(edx, memd[gs, edx + 0x30]);         /* mov edx, [gs:edx+0x30] */
            ii(0x1018_055b, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_055e, 4); mov(memd[gs, eax + 0x18], edx);         /* mov [gs:eax+0x18], edx */
            ii(0x1018_0562, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0569, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_056d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_056f, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0576, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_057a, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0580, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_0584, 4); mov(edx, memd[gs, edx + 0x30]);         /* mov edx, [gs:edx+0x30] */
            ii(0x1018_0588, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_058b, 4); mov(memd[gs, eax + 0x1c], edx);         /* mov [gs:eax+0x1c], edx */
            ii(0x1018_058f, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0596, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_059a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_059c, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_05a3, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_05a7, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_05ad, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_05b1, 4); mov(edx, memd[gs, edx + 0x34]);         /* mov edx, [gs:edx+0x34] */
            ii(0x1018_05b5, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_05b8, 4); mov(memd[gs, eax + 0x20], edx);         /* mov [gs:eax+0x20], edx */
            ii(0x1018_05bc, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_05c0, 4); mov(eax, memd[gs, eax + 0x30]);         /* mov eax, [gs:eax+0x30] */
            ii(0x1018_05c4, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_05c8, 4); add(eax, memd[gs, edx + 0x34]);         /* add eax, [gs:edx+0x34] */
            ii(0x1018_05cc, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_05d0, 4); mov(edx, memd[gs, edx + 0x2c]);         /* mov edx, [gs:edx+0x2c] */
            ii(0x1018_05d4, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1018_05d6, 7); imul(ebx, memd[ss, ebp - 0x10], 0xc0);  /* imul ebx, [ebp-0x10], 0xc0 */
            ii(0x1018_05dd, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_05e1, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1018_05e3, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_05ea, 4); mov(memd[gs, eax + 0x2c], edx);         /* mov [gs:eax+0x2c], edx */
            ii(0x1018_05ee, 2); jmp(0x1018_064a, 0x5a); goto l_0x1018_064a; /* jmp 0x1018064a */
        l_0x1018_05f0:
            ii(0x1018_05f0, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_05f7, 4); imul(edx, memd[ss, ebp - 0xc], 6);      /* imul edx, [ebp-0xc], 0x6 */
            ii(0x1018_05fb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_05fd, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0604, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0608, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_060e, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_0612, 4); mov(edx, memd[gs, edx + 8]);            /* mov edx, [gs:edx+0x8] */
            ii(0x1018_0616, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0619, 4); mov(memd[gs, eax + 0x18], edx);         /* mov [gs:eax+0x18], edx */
            ii(0x1018_061d, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0624, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0628, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_062a, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_0631, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0635, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_063b, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_063f, 4); mov(edx, memd[gs, edx + 8]);            /* mov edx, [gs:edx+0x8] */
            ii(0x1018_0643, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0646, 4); mov(memd[gs, eax + 0x1c], edx);         /* mov [gs:eax+0x1c], edx */
        l_0x1018_064a:
            ii(0x1018_064a, 7); imul(eax, memd[ss, ebp - 0x10], 0xc0);  /* imul eax, [ebp-0x10], 0xc0 */
            ii(0x1018_0651, 4); imul(edx, memd[ss, ebp - 0xc], 6);      /* imul edx, [ebp-0xc], 0x6 */
            ii(0x1018_0655, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0657, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_065e, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0662, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0668, 4); lgs(ebx, memd[ss, ebp - 0x18]);         /* lgs ebx, [ebp-0x18] */
            ii(0x1018_066c, 5); mov(dx, memw[gs, ebx + 0x18]);          /* mov dx, [gs:ebx+0x18] */
            ii(0x1018_0671, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0674, 5); mov(memw[gs, eax + 0x34], dx);          /* mov [gs:eax+0x34], dx */
            ii(0x1018_0679, 4); lgs(eax, memd[ss, ebp - 0x18]);         /* lgs eax, [ebp-0x18] */
            ii(0x1018_067d, 5); mov(bx, memw[gs, eax + 0x28]);          /* mov bx, [gs:eax+0x28] */
            ii(0x1018_0682, 3); or(bh, 0x88);                           /* or bh, 0x88 */
            ii(0x1018_0685, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_068c, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0690, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0692, 7); lgs(eax, memd[ds, eax + 0x1020_b718]);  /* lgs eax, [eax+0x1020b718] */
            ii(0x1018_0699, 5); mov(memw[gs, eax + 0x30], bx);          /* mov [gs:eax+0x30], bx */
            ii(0x1018_069e, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_06a5, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_06a9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_06ab, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_06b2, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_06b6, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_06bc, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_06c0, 5); mov(dx, memw[gs, edx + 0x20]);          /* mov dx, [gs:edx+0x20] */
            ii(0x1018_06c5, 4); lgs(ebx, memd[ss, ebp - 0x18]);         /* lgs ebx, [ebp-0x18] */
            ii(0x1018_06c9, 4); mov(ebx, memd[gs, ebx + 0x1c]);         /* mov ebx, [gs:ebx+0x1c] */
            ii(0x1018_06cd, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_06d0, 5); mov(memw[gs, eax + 0x40], dx);          /* mov [gs:eax+0x40], dx */
            ii(0x1018_06d5, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_06d8, 4); mov(memd[gs, eax + 0x3c], ebx);         /* mov [gs:eax+0x3c], ebx */
            ii(0x1018_06dc, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_06e3, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_06e7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_06e9, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_06f0, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_06f4, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_06fa, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_06fe, 5); mov(dx, memw[gs, edx + 0xc]);           /* mov dx, [gs:edx+0xc] */
            ii(0x1018_0703, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0706, 5); mov(memw[gs, eax + 0x38], dx);          /* mov [gs:eax+0x38], dx */
            ii(0x1018_070b, 7); imul(edx, memd[ss, ebp - 0x10], 0xc0);  /* imul edx, [ebp-0x10], 0xc0 */
            ii(0x1018_0712, 4); imul(eax, memd[ss, ebp - 0xc], 6);      /* imul eax, [ebp-0xc], 0x6 */
            ii(0x1018_0716, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_0718, 7); mov(dx, memw[ds, eax + 0x1020_b71c]);   /* mov dx, [eax+0x1020b71c] */
            ii(0x1018_071f, 4); mov(memw[ss, ebp - 0x2c], dx);          /* mov [ebp-0x2c], dx */
            ii(0x1018_0723, 6); mov(eax, memd[ds, eax + 0x1020_b718]);  /* mov eax, [eax+0x1020b718] */
            ii(0x1018_0729, 4); lgs(edx, memd[ss, ebp - 0x18]);         /* lgs edx, [ebp-0x18] */
            ii(0x1018_072d, 5); mov(dx, memw[gs, edx + 0x24]);          /* mov dx, [gs:edx+0x24] */
            ii(0x1018_0732, 3); mov(gs, memw[ss, ebp - 0x2c]);          /* mov gs, [ebp-0x2c] */
            ii(0x1018_0735, 5); mov(memw[gs, eax + 0x4a], dx);          /* mov [gs:eax+0x4a], dx */
            ii(0x1018_073a, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
            ii(0x1018_0741, 2); jmp(0x1018_074a, 7); goto l_0x1018_074a; /* jmp 0x1018074a */
        l_0x1018_0743:
            ii(0x1018_0743, 7); mov(memd[ss, ebp - 4], 0);              /* mov dword [ebp-0x4], 0x0 */
        l_0x1018_074a:
            ii(0x1018_074a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1018_074d, 1); leave();                                /* leave */
            ii(0x1018_074e, 1); pop(edi);                               /* pop edi */
            ii(0x1018_074f, 1); pop(esi);                               /* pop esi */
            ii(0x1018_0750, 1); ret();                                  /* ret */
        }
    }
}
