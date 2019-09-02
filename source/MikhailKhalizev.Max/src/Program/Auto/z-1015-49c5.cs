using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_49c5-bc9a7824")]
        public void Method_1015_49c5()
        {
            ii(0x1015_49c5, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_49ca, 5); call(Definitions.sys_check_available_stack_size, 0x1_1383); /* call 0x10165d52 */
            ii(0x1015_49cf, 1); push(ebx);                              /* push ebx */
            ii(0x1015_49d0, 1); push(ecx);                              /* push ecx */
            ii(0x1015_49d1, 1); push(esi);                              /* push esi */
            ii(0x1015_49d2, 1); push(edi);                              /* push edi */
            ii(0x1015_49d3, 1); push(ebp);                              /* push ebp */
            ii(0x1015_49d4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_49d6, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_49dc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_49df, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_49e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_49e4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_49e7, 3); mov(al, memb[ds, edx + 0x26]);          /* mov al, [edx+0x26] */
            ii(0x1015_49ea, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_49ed, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_49f0, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1015_49f4, 6); if(jz(0x1015_4b83, 0x189)) goto l_0x1015_4b83; /* jz 0x10154b83 */
            ii(0x1015_49fa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_49fd, 5); call(0x1011_fe27, -0x3_4bdb);           /* call 0x1011fe27 */
            ii(0x1015_4a02, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_4a05, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a08, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_4a0a, 3); mov(bl, memb[ds, eax + 0x26]);          /* mov bl, [eax+0x26] */
            ii(0x1015_4a0d, 3); imul(ebx, ebx, 0xa);                    /* imul ebx, ebx, 0xa */
            ii(0x1015_4a10, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_4a15, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_4a17, 5); call(0x1008_aab4, -0xc_9f68);           /* call 0x1008aab4 */
            ii(0x1015_4a1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a1f, 5); call(0x1014_b6bd, -0x9367);             /* call 0x1014b6bd */
            ii(0x1015_4a24, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4a26, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a29, 5); call(0x1008_a998, -0xc_a096);           /* call 0x1008a998 */
            ii(0x1015_4a2e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4a30, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a33, 5); call(0x1007_60ac, -0xd_e98c);           /* call 0x100760ac */
            ii(0x1015_4a38, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4a3a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a3d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_4a40, 5); call(0x1007_6a34, -0xd_e011);           /* call 0x10076a34 */
            ii(0x1015_4a45, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a48, 5); call(0x1015_287d, -0x21d0);             /* call 0x1015287d */
            ii(0x1015_4a4d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a50, 5); call(0x100a_8e92, -0xa_bbc3);           /* call 0x100a8e92 */
            ii(0x1015_4a55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4a57, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a5a, 5); call(0x1007_1838, -0xe_3227);           /* call 0x10071838 */
            ii(0x1015_4a5f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a62, 3); mov(edx, memd[ds, eax + 0x1a]);         /* mov edx, [eax+0x1a] */
            ii(0x1015_4a65, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_4a68, 5); mov(eax, memd[ds, 0x101c_8170]);        /* mov eax, [0x101c8170] */
            ii(0x1015_4a6d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_4a70, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1015_4a73, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a76, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1015_4a79, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_4a7c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1015_4a7e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4a81, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_4a84, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4a89, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4a8f, 6); mov(eax, memd[ds, eax + 0x101c_a6a3]);  /* mov eax, [eax+0x101ca6a3] */
            ii(0x1015_4a95, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1015_4a97, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1015_4a99, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4a9e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4aa0, 2); if(jz(0x1015_4aa8, 6)) goto l_0x1015_4aa8; /* jz 0x10154aa8 */
            ii(0x1015_4aa2, 4); mov(memb[ss, ebp - 0x10], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_4aa6, 2); jmp(0x1015_4aac, 4); goto l_0x1015_4aac; /* jmp 0x10154aac */
        l_0x1015_4aa8:
            ii(0x1015_4aa8, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_4aac:
            ii(0x1015_4aac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4aaf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4ab1, 3); mov(dl, memb[ds, eax + 0x26]);          /* mov dl, [eax+0x26] */
            ii(0x1015_4ab4, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x1015_4ab7, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x1015_4aba, 6); mov(memb[ds, edx + 0xab], al);          /* mov [edx+0xab], al */
            ii(0x1015_4ac0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4ac3, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1015_4ac6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4acb, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4ad1, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1015_4ad7, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1015_4ada, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1015_4adf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_4ae1, 2); not(edx);                               /* not edx */
            ii(0x1015_4ae3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4ae6, 3); and(memd[ds, eax + 0x12], edx);         /* and [eax+0x12], edx */
            ii(0x1015_4ae9, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1015_4aec, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1015_4aef, 3); mov(memb[ds, edx + 0x26], al);          /* mov [edx+0x26], al */
            ii(0x1015_4af2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4af5, 4); mov(memb[ds, eax + 0x5c], 0);           /* mov byte [eax+0x5c], 0x0 */
            ii(0x1015_4af9, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_4afd, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4b03, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1015_4b09, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_4b0b, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x1015_4b0e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b11, 3); or(memd[ds, eax + 0x12], edx);          /* or [eax+0x12], edx */
            ii(0x1015_4b14, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_4b18, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1015_4b1e, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1015_4b24, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1015_4b27, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b2a, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
            ii(0x1015_4b2d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b30, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1015_4b34, 2); if(jnz(0x1015_4b45, 0xf)) goto l_0x1015_4b45; /* jnz 0x10154b45 */
            ii(0x1015_4b36, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b39, 5); call(0x1014_f08b, -0x5ab3);             /* call 0x1014f08b */
            ii(0x1015_4b3e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b41, 4); mov(memb[ds, eax + 0x58], 0);           /* mov byte [eax+0x58], 0x0 */
        l_0x1015_4b45:
            ii(0x1015_4b45, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_4b4a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b4d, 5); call(0x1007_1838, -0xe_331a);           /* call 0x10071838 */
            ii(0x1015_4b52, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1015_4b56, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1015_4b59, 7); mov(memb[ds, eax + 0xab], 1);           /* mov byte [eax+0xab], 0x1 */
            ii(0x1015_4b60, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b63, 5); call(0x100a_8d5f, -0xa_be09);           /* call 0x100a8d5f */
            ii(0x1015_4b68, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x1015_4b6c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b6f, 5); call(0x100a_9060, -0xa_bb14);           /* call 0x100a9060 */
            ii(0x1015_4b74, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_4b77, 5); call(0x1014_9fa8, -0xabd4);             /* call 0x10149fa8 */
            ii(0x1015_4b7c, 7); mov(memb[ds, 0x101c_391b], 1);          /* mov byte [0x101c391b], 0x1 */
        l_0x1015_4b83:
            ii(0x1015_4b83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_4b85, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_4b86, 1); pop(edi);                               /* pop edi */
            ii(0x1015_4b87, 1); pop(esi);                               /* pop esi */
            ii(0x1015_4b88, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_4b89, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_4b8a, 1); ret();                                  /* ret */
        }
    }
}
