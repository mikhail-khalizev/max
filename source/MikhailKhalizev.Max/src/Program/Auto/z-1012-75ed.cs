using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_75ed-683cdafc")]
        public void Method_1012_75ed()
        {
            ii(0x1012_75ed, 5); push(0xd4);                             /* push 0xd4 */
            ii(0x1012_75f2, 5); call(Definitions.sys_check_available_stack_size, 0x3_e75b); /* call 0x10165d52 */
            ii(0x1012_75f7, 1); push(ebx);                              /* push ebx */
            ii(0x1012_75f8, 1); push(ecx);                              /* push ecx */
            ii(0x1012_75f9, 1); push(edx);                              /* push edx */
            ii(0x1012_75fa, 1); push(esi);                              /* push esi */
            ii(0x1012_75fb, 1); push(edi);                              /* push edi */
            ii(0x1012_75fc, 1); push(ebp);                              /* push ebp */
            ii(0x1012_75fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_75ff, 6); sub(esp, 0xac);                         /* sub esp, 0xac */
            ii(0x1012_7605, 7); mov(memd[ss, ebp - 0x4], 0x101c_59f5);  /* mov dword [ebp-0x4], 0x101c59f5 */
        l_0x1012_760c:
            ii(0x1012_760c, 5); call(0x1012_5d1f, -0x18f2);             /* call 0x10125d1f */
            ii(0x1012_7611, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7613, 6); if(jz(0x1012_85f9, 0xfe0)) goto l_0x1012_85f9; /* jz 0x101285f9 */
            ii(0x1012_7619, 6); mov(ax, memw[ds, 0x101c_59f1]);         /* mov ax, [0x101c59f1] */
            ii(0x1012_761f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1012_7622, 6); mov(ax, memw[ds, 0x101c_59f3]);         /* mov ax, [0x101c59f3] */
            ii(0x1012_7628, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_762b, 5); mov(al, memb[ds, 0x101c_59f0]);         /* mov al, [0x101c59f0] */
            ii(0x1012_7630, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1012_7633, 5); jmp(0x1012_85cc, 0xf94); goto l_0x1012_85cc; /* jmp 0x101285cc */
        l_0x1012_7638:
            ii(0x1012_7638, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_763c, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_7642, 6); mov(memb[ds, eax + 0x101c_59d0], dl);   /* mov [eax+0x101c59d0], dl */
            ii(0x1012_7648, 5); jmp(0x1012_85f4, 0xfa7); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_764d:
            ii(0x1012_764d, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7651, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_7657, 6); mov(memb[ds, eax + 0x101c_59dc], dl);   /* mov [eax+0x101c59dc], dl */
            ii(0x1012_765d, 5); jmp(0x1012_85f4, 0xf92); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7662:
            ii(0x1012_7662, 7); mov(memd[ss, ebp - 0x18], 0x101c_59f5); /* mov dword [ebp-0x18], 0x101c59f5 */
            ii(0x1012_7669, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_766d, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_7670, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1012_7672, 6); mov(memb[ds, edx + 0x101c_59d4], al);   /* mov [edx+0x101c59d4], al */
            ii(0x1012_7678, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_767c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_767e, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_7681, 4); mov(ax, memw[ds, eax + 0x1]);           /* mov ax, [eax+0x1] */
            ii(0x1012_7685, 7); mov(memw[ds, edx + 0x101c_59e4], ax);   /* mov [edx+0x101c59e4], ax */
            ii(0x1012_768c, 5); jmp(0x1012_85f4, 0xf63); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7691:
            ii(0x1012_7691, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7698, 6); if(jnz(0x1012_77d0, 0x132)) goto l_0x1012_77d0; /* jnz 0x101277d0 */
            ii(0x1012_769e, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_76a3, 3); mov(al, memb[ds, eax + 0x10]);          /* mov al, [eax+0x10] */
            ii(0x1012_76a6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_76ab, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1012_76ae, 6); if(jz(0x1012_85f4, 0xf40)) goto l_0x1012_85f4; /* jz 0x101285f4 */
            ii(0x1012_76b4, 4); mov(memb[ss, ebp - 0x20], 0);           /* mov byte [ebp-0x20], 0x0 */
            ii(0x1012_76b8, 4); mov(memb[ss, ebp - 0x1c], 0x8);         /* mov byte [ebp-0x1c], 0x8 */
        l_0x1012_76bc:
            ii(0x1012_76bc, 3); dec(memb[ss, ebp - 0x1c]);              /* dec byte [ebp-0x1c] */
            ii(0x1012_76bf, 4); cmp(memb[ss, ebp - 0x1c], -0x1 /* 0xff */); /* cmp byte [ebp-0x1c], 0xff */
            ii(0x1012_76c3, 2); if(jz(0x1012_76e8, 0x23)) goto l_0x1012_76e8; /* jz 0x101276e8 */
            ii(0x1012_76c5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_76c7, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1012_76ca, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_76cc, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_76ce, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_76d3, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_76d5, 7); mov(ax, memw[ds, eax + 0x328]);         /* mov ax, [eax+0x328] */
            ii(0x1012_76dc, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_76e0, 2); if(jnz(0x1012_76e6, 0x4)) goto l_0x1012_76e6; /* jnz 0x101276e6 */
            ii(0x1012_76e2, 4); mov(memb[ss, ebp - 0x20], 0x1);         /* mov byte [ebp-0x20], 0x1 */
        l_0x1012_76e6:
            ii(0x1012_76e6, 2); jmp(0x1012_76bc, -0x2c); goto l_0x1012_76bc; /* jmp 0x101276bc */
        l_0x1012_76e8:
            ii(0x1012_76e8, 4); cmp(memb[ss, ebp - 0x20], 0);           /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1012_76ec, 6); if(jnz(0x1012_77d0, 0xde)) goto l_0x1012_77d0; /* jnz 0x101277d0 */
            ii(0x1012_76f2, 5); mov(eax, StringDefinitions.V1043);      /* mov eax, 0x101a826e */
            ii(0x1012_76f7, 5); call(Definitions.sys_strlen, 0x4_a7cb); /* call 0x10171ec7 */
            ii(0x1012_76fc, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1012_76ff, 4); movsx(ebx, memw[ss, ebp - 0x24]);       /* movsx ebx, word [ebp-0x24] */
            ii(0x1012_7703, 5); mov(edx, StringDefinitions.V1044);      /* mov edx, 0x101a8274 */
            ii(0x1012_7708, 5); mov(eax, 0x101c_59f5);                  /* mov eax, 0x101c59f5 */
            ii(0x1012_770d, 5); call(Definitions.sys_strncmp, 0x5_1a4a); /* call 0x1017915c */
            ii(0x1012_7712, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7714, 2); if(jz(0x1012_7759, 0x43)) goto l_0x1012_7759; /* jz 0x10127759 */
            ii(0x1012_7716, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7718, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_771d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1012_7720, 2); if(jz(0x1012_772e, 0xc)) goto l_0x1012_772e; /* jz 0x1012772e */
            ii(0x1012_7722, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7724, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_7729, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1012_772c, 2); if(jnz(0x1012_7754, 0x26)) goto l_0x1012_7754; /* jnz 0x10127754 */
        l_0x1012_772e:
            ii(0x1012_772e, 5); call(0x100c_aa00, -0x5_cd33);           /* call 0x100caa00 */
            ii(0x1012_7733, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_7738, 1); push(eax);                              /* push eax */
            ii(0x1012_7739, 5); call(0x100c_aa20, -0x5_cd1e);           /* call 0x100caa20 */
            ii(0x1012_773e, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_7740, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_7745, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_774a, 5); mov(eax, StringDefinitions.HostIsNotTheSameReleaseVersionUnableToContinueWithConnection); /* mov eax, 0x101a827a */
            ii(0x1012_774f, 5); call(0x1011_5d23, -0x1_1a31);           /* call 0x10115d23 */
        l_0x1012_7754:
            ii(0x1012_7754, 5); jmp(0x1012_85f4, 0xe9b); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7759:
            ii(0x1012_7759, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1012_775d, 2); jmp(0x1012_7765, 0x6); goto l_0x1012_7765; /* jmp 0x10127765 */
        l_0x1012_775f:
            ii(0x1012_775f, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1012_7762, 3); inc(memb[ss, ebp - 0x1c]);              /* inc byte [ebp-0x1c] */
        l_0x1012_7765:
            ii(0x1012_7765, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7767, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1012_776a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_776c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_776e, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7773, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7775, 6); mov(eax, memd[ds, eax + 0x326]);        /* mov eax, [eax+0x326] */
            ii(0x1012_777b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_777e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7780, 2); if(jnz(0x1012_775f, -0x23)) goto l_0x1012_775f; /* jnz 0x1012775f */
            ii(0x1012_7782, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x1012_7786, 5); mov(eax, 0x101c_59f5);                  /* mov eax, 0x101c59f5 */
            ii(0x1012_778b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_778d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_778f, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1012_7792, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1012_7795, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_779a, 5); add(eax, 0x238);                        /* add eax, 0x238 */
            ii(0x1012_779f, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_77a1, 5); call(Definitions.sys_strcpy, 0x3_e729); /* call 0x10165ecf */
            ii(0x1012_77a6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_77a8, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1012_77ab, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_77ad, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_77b3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_77b5, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_77b8, 7); mov(memw[ds, edx + 0x328], ax);         /* mov [edx+0x328], ax */
            ii(0x1012_77bf, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_77c4, 3); inc(memb[ds, eax + 0x10]);              /* inc byte [eax+0x10] */
            ii(0x1012_77c7, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_77cc, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_77d0:
            ii(0x1012_77d0, 5); jmp(0x1012_85f4, 0xe1f); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_77d5:
            ii(0x1012_77d5, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_77dc, 2); if(jnz(0x1012_77ee, 0x10)) goto l_0x1012_77ee; /* jnz 0x101277ee */
            ii(0x1012_77de, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_77e3, 4); cmp(memb[ds, eax + 0x8], 0);            /* cmp byte [eax+0x8], 0x0 */
            ii(0x1012_77e7, 2); if(jz(0x1012_77ee, 0x5)) goto l_0x1012_77ee; /* jz 0x101277ee */
            ii(0x1012_77e9, 5); call(0x1012_a96a, 0x317c);              /* call 0x1012a96a */
        l_0x1012_77ee:
            ii(0x1012_77ee, 5); jmp(0x1012_85f4, 0xe01); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_77f3:
            ii(0x1012_77f3, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_77fa, 2); if(jnz(0x1012_7824, 0x28)) goto l_0x1012_7824; /* jnz 0x10127824 */
            ii(0x1012_77fc, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7801, 4); mov(ax, memw[ds, eax + 0x14]);          /* mov ax, [eax+0x14] */
            ii(0x1012_7805, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7809, 2); if(jnz(0x1012_7824, 0x19)) goto l_0x1012_7824; /* jnz 0x10127824 */
            ii(0x1012_780b, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1012_7810, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7815, 5); mov(eax, 0x101c_4090);                  /* mov eax, 0x101c4090 */
            ii(0x1012_781a, 5); call(Definitions.sys_memcpy, 0x3_e62c); /* call 0x10165e4b */
            ii(0x1012_781f, 5); call(0x1012_7184, -0x6a0);              /* call 0x10127184 */
        l_0x1012_7824:
            ii(0x1012_7824, 5); jmp(0x1012_85f4, 0xdcb); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7829:
            ii(0x1012_7829, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7830, 6); if(jnz(0x1012_78dc, 0xa6)) goto l_0x1012_78dc; /* jnz 0x101278dc */
            ii(0x1012_7836, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_783c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_783f, 4); mov(memw[ds, edx + 0x14], ax);          /* mov [edx+0x14], ax */
            ii(0x1012_7843, 7); mov(memd[ss, ebp - 0x28], 0x101c_59f5); /* mov dword [ebp-0x28], 0x101c59f5 */
            ii(0x1012_784a, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_7850, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1012_7853, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1012_7856, 4); mov(memw[ds, edx + 0xc], ax);           /* mov [edx+0xc], ax */
            ii(0x1012_785a, 7); mov(memd[ss, ebp - 0x2c], 0x4);         /* mov dword [ebp-0x2c], 0x4 */
        l_0x1012_7861:
            ii(0x1012_7861, 3); dec(memd[ss, ebp - 0x2c]);              /* dec dword [ebp-0x2c] */
            ii(0x1012_7864, 5); cmp(memw[ss, ebp - 0x2c], -0x1 /* 0xff */); /* cmp word [ebp-0x2c], 0xffff */
            ii(0x1012_7869, 2); if(jz(0x1012_78b6, 0x4b)) goto l_0x1012_78b6; /* jz 0x101278b6 */
            ii(0x1012_786b, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_786f, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1012_7872, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1012_7875, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1012_7878, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_787a, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1012_787e, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1012_7881, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7886, 5); add(eax, 0x338);                        /* add eax, 0x338 */
            ii(0x1012_788b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_788d, 5); call(Definitions.sys_strcpy, 0x3_e63d); /* call 0x10165ecf */
            ii(0x1012_7892, 4); movsx(eax, memw[ss, ebp - 0x2c]);       /* movsx eax, word [ebp-0x2c] */
            ii(0x1012_7896, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7898, 3); add(eax, memd[ss, ebp - 0x28]);         /* add eax, [ebp-0x28] */
            ii(0x1012_789b, 4); movsx(edx, memw[ss, ebp - 0x2c]);       /* movsx edx, word [ebp-0x2c] */
            ii(0x1012_789f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_78a1, 6); mov(ebx, memd[ds, 0x101c_59cc]);        /* mov ebx, [0x101c59cc] */
            ii(0x1012_78a7, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1012_78a9, 4); mov(ax, memw[ds, eax + 0x7a]);          /* mov ax, [eax+0x7a] */
            ii(0x1012_78ad, 7); mov(memw[ds, edx + 0x4dc], ax);         /* mov [edx+0x4dc], ax */
            ii(0x1012_78b4, 2); jmp(0x1012_7861, -0x55); goto l_0x1012_7861; /* jmp 0x10127861 */
        l_0x1012_78b6:
            ii(0x1012_78b6, 5); mov(ebx, 0xad);                         /* mov ebx, 0xad */
            ii(0x1012_78bb, 3); mov(edx, memd[ss, ebp - 0x28]);         /* mov edx, [ebp-0x28] */
            ii(0x1012_78be, 6); add(edx, 0x82);                         /* add edx, 0x82 */
            ii(0x1012_78c4, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_78c9, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1012_78ce, 5); call(Definitions.sys_memcpy, 0x3_e578); /* call 0x10165e4b */
            ii(0x1012_78d3, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_78d8, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_78dc:
            ii(0x1012_78dc, 5); jmp(0x1012_85f4, 0xd13); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_78e1:
            ii(0x1012_78e1, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_78e8, 6); if(jnz(0x1012_7ad3, 0x1e5)) goto l_0x1012_7ad3; /* jnz 0x10127ad3 */
            ii(0x1012_78ee, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_78f3, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_78f7, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_78fb, 6); if(jnz(0x1012_79ae, 0xad)) goto l_0x1012_79ae; /* jnz 0x101279ae */
            ii(0x1012_7901, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7903, 5); mov(al, memb[ds, 0x101c_59f0]);         /* mov al, [0x101c59f0] */
            ii(0x1012_7908, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1012_790b, 2); if(jnz(0x1012_7921, 0x14)) goto l_0x1012_7921; /* jnz 0x10127921 */
            ii(0x1012_790d, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7912, 3); mov(al, memb[ds, eax + 0x11]);          /* mov al, [eax+0x11] */
            ii(0x1012_7915, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_791a, 5); cmp(eax, 0xff);                         /* cmp eax, 0xff */
            ii(0x1012_791f, 2); if(jnz(0x1012_7923, 0x2)) goto l_0x1012_7923; /* jnz 0x10127923 */
        l_0x1012_7921:
            ii(0x1012_7921, 2); jmp(0x1012_7991, 0x6e); goto l_0x1012_7991; /* jmp 0x10127991 */
        l_0x1012_7923:
            ii(0x1012_7923, 5); call(0x1012_72a5, -0x683);              /* call 0x101272a5 */
            ii(0x1012_7928, 7); mov(memb[ds, 0x101c_5630], 0x2);        /* mov byte [0x101c5630], 0x2 */
            ii(0x1012_792f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7931, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_7936, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1012_7939, 2); if(jnz(0x1012_7983, 0x48)) goto l_0x1012_7983; /* jnz 0x10127983 */
            ii(0x1012_793b, 7); mov(memd[ss, ebp - 0x30], 0x101c_59f5); /* mov dword [ebp-0x30], 0x101c59f5 */
            ii(0x1012_7942, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1012_7947, 3); mov(edx, memd[ss, ebp - 0x30]);         /* mov edx, [ebp-0x30] */
            ii(0x1012_794a, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_794d, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_7950, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1012_7953, 3); imul(ecx, eax, 0x6);                    /* imul ecx, eax, 0x6 */
            ii(0x1012_7956, 5); mov(eax, 0x101c_4090);                  /* mov eax, 0x101c4090 */
            ii(0x1012_795b, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_795d, 5); call(Definitions.sys_memcpy, 0x3_e4e9); /* call 0x10165e4b */
            ii(0x1012_7962, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_7965, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1012_7969, 6); mov(memw[ds, 0x101c_40d0], ax);         /* mov [0x101c40d0], ax */
            ii(0x1012_796f, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x1012_7972, 3); movsx(ebx, memw[ds, eax]);              /* movsx ebx, word [eax] */
            ii(0x1012_7975, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_7977, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_797c, 5); call(0x1012_70fb, -0x886);              /* call 0x101270fb */
            ii(0x1012_7981, 2); jmp(0x1012_798c, 0x9); goto l_0x1012_798c; /* jmp 0x1012798c */
        l_0x1012_7983:
            ii(0x1012_7983, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7988, 4); mov(memb[ds, eax + 0xa], 0x1);          /* mov byte [eax+0xa], 0x1 */
        l_0x1012_798c:
            ii(0x1012_798c, 5); jmp(0x1012_85f4, 0xc63); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7991:
            ii(0x1012_7991, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7996, 6); mov(memw[ds, eax + 0xc], 0);            /* mov word [eax+0xc], 0x0 */
            ii(0x1012_799c, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_79a1, 4); mov(memb[ds, eax + 0xb], 0);            /* mov byte [eax+0xb], 0x0 */
            ii(0x1012_79a5, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_79aa, 4); mov(memb[ds, eax + 0x11], 0xff);        /* mov byte [eax+0x11], 0xff */
        l_0x1012_79ae:
            ii(0x1012_79ae, 7); mov(memd[ss, ebp - 0x34], 0x8);         /* mov dword [ebp-0x34], 0x8 */
        l_0x1012_79b5:
            ii(0x1012_79b5, 3); dec(memd[ss, ebp - 0x34]);              /* dec dword [ebp-0x34] */
            ii(0x1012_79b8, 5); cmp(memw[ss, ebp - 0x34], -0x1 /* 0xff */); /* cmp word [ebp-0x34], 0xffff */
            ii(0x1012_79bd, 2); if(jz(0x1012_7a1a, 0x5b)) goto l_0x1012_7a1a; /* jz 0x10127a1a */
            ii(0x1012_79bf, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1012_79c3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_79c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_79c7, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_79cc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_79ce, 7); mov(ax, memw[ds, eax + 0x328]);         /* mov ax, [eax+0x328] */
            ii(0x1012_79d5, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_79d9, 2); if(jnz(0x1012_7a18, 0x3d)) goto l_0x1012_7a18; /* jnz 0x10127a18 */
            ii(0x1012_79db, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1012_79df, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_79e1, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_79e7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_79e9, 9); mov(memw[ds, eax + 0x328], 0);          /* mov word [eax+0x328], 0x0 */
            ii(0x1012_79f2, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1012_79f6, 3); imul(edx, edx, 0x1e);                   /* imul edx, edx, 0x1e */
            ii(0x1012_79f9, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_79fe, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7a00, 7); mov(memb[ds, eax + 0x238], 0);          /* mov byte [eax+0x238], 0x0 */
            ii(0x1012_7a07, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a0c, 3); dec(memb[ds, eax + 0x10]);              /* dec byte [eax+0x10] */
            ii(0x1012_7a0f, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a14, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7a18:
            ii(0x1012_7a18, 2); jmp(0x1012_79b5, -0x65); goto l_0x1012_79b5; /* jmp 0x101279b5 */
        l_0x1012_7a1a:
            ii(0x1012_7a1a, 7); mov(memd[ss, ebp - 0x34], 0x4);         /* mov dword [ebp-0x34], 0x4 */
        l_0x1012_7a21:
            ii(0x1012_7a21, 3); dec(memd[ss, ebp - 0x34]);              /* dec dword [ebp-0x34] */
            ii(0x1012_7a24, 5); cmp(memw[ss, ebp - 0x34], -0x1 /* 0xff */); /* cmp word [ebp-0x34], 0xffff */
            ii(0x1012_7a29, 6); if(jz(0x1012_7ac5, 0x96)) goto l_0x1012_7ac5; /* jz 0x10127ac5 */
            ii(0x1012_7a2f, 4); movsx(eax, memw[ss, ebp - 0x34]);       /* movsx eax, word [ebp-0x34] */
            ii(0x1012_7a33, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7a35, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_7a37, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a3c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7a3e, 7); mov(ax, memw[ds, eax + 0x4dc]);         /* mov ax, [eax+0x4dc] */
            ii(0x1012_7a45, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7a49, 2); if(jnz(0x1012_7ac0, 0x75)) goto l_0x1012_7ac0; /* jnz 0x10127ac0 */
            ii(0x1012_7a4b, 4); movsx(edx, memw[ss, ebp - 0x34]);       /* movsx edx, word [ebp-0x34] */
            ii(0x1012_7a4f, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a54, 5); call(0x1011_3129, -0x1_4930);           /* call 0x10113129 */
            ii(0x1012_7a59, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a5e, 4); cmp(memb[ds, eax + 0x8], 0);            /* cmp byte [eax+0x8], 0x0 */
            ii(0x1012_7a62, 2); if(jz(0x1012_7a6c, 0x8)) goto l_0x1012_7a6c; /* jz 0x10127a6c */
            ii(0x1012_7a64, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a69, 3); dec(memb[ds, eax + 0xf]);               /* dec byte [eax+0xf] */
        l_0x1012_7a6c:
            ii(0x1012_7a6c, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7a70, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_7a73, 2); if(jg(0x1012_7ab7, 0x42)) goto l_0x1012_7ab7; /* jg 0x10127ab7 */
            ii(0x1012_7a75, 3); mov(al, memb[ss, ebp - 0x34]);          /* mov al, [ebp-0x34] */
            ii(0x1012_7a78, 2); add(al, 0xd);                           /* add al, 0xd */
            ii(0x1012_7a7a, 3); mov(memb[ss, ebp - 0x38], al);          /* mov [ebp-0x38], al */
            ii(0x1012_7a7d, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1012_7a82, 4); movsx(eax, memb[ss, ebp - 0x38]);       /* movsx eax, byte [ebp-0x38] */
            ii(0x1012_7a86, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_7a89, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_7a8b, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7a90, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_7a92, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1012_7a95, 5); call(0x100c_f211, -0x5_8889);           /* call 0x100cf211 */
            ii(0x1012_7a9a, 5); mov(edx, 0x30a);                        /* mov edx, 0x30a */
            ii(0x1012_7a9f, 4); movsx(eax, memb[ss, ebp - 0x38]);       /* movsx eax, byte [ebp-0x38] */
            ii(0x1012_7aa3, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_7aa6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_7aa8, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7aad, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_7aaf, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1012_7ab2, 5); call(0x100c_f363, -0x5_8754);           /* call 0x100cf363 */
        l_0x1012_7ab7:
            ii(0x1012_7ab7, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7abc, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7ac0:
            ii(0x1012_7ac0, 5); jmp(0x1012_7a21, -0xa4); goto l_0x1012_7a21; /* jmp 0x10127a21 */
        l_0x1012_7ac5:
            ii(0x1012_7ac5, 7); mov(memb[ds, 0x101c_59b9], 0);          /* mov byte [0x101c59b9], 0x0 */
            ii(0x1012_7acc, 7); mov(memb[ds, 0x101c_59ba], 0);          /* mov byte [0x101c59ba], 0x0 */
        l_0x1012_7ad3:
            ii(0x1012_7ad3, 5); jmp(0x1012_85f4, 0xb1c); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7ad8:
            ii(0x1012_7ad8, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7adf, 2); if(jnz(0x1012_7af0, 0xf)) goto l_0x1012_7af0; /* jnz 0x10127af0 */
            ii(0x1012_7ae1, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7ae6, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_7aea, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7aee, 2); if(jz(0x1012_7af5, 0x5)) goto l_0x1012_7af5; /* jz 0x10127af5 */
        l_0x1012_7af0:
            ii(0x1012_7af0, 5); jmp(0x1012_7bb1, 0xbc); goto l_0x1012_7bb1; /* jmp 0x10127bb1 */
        l_0x1012_7af5:
            ii(0x1012_7af5, 7); mov(memd[ss, ebp - 0x3c], 0x101c_59f5); /* mov dword [ebp-0x3c], 0x101c59f5 */
            ii(0x1012_7afc, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_7aff, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1012_7b02, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x1012_7b05, 7); mov(memd[ss, ebp - 0x44], 0x4);         /* mov dword [ebp-0x44], 0x4 */
        l_0x1012_7b0c:
            ii(0x1012_7b0c, 3); dec(memd[ss, ebp - 0x44]);              /* dec dword [ebp-0x44] */
            ii(0x1012_7b0f, 5); cmp(memw[ss, ebp - 0x44], -0x1 /* 0xff */); /* cmp word [ebp-0x44], 0xffff */
            ii(0x1012_7b14, 2); if(jz(0x1012_7b4a, 0x34)) goto l_0x1012_7b4a; /* jz 0x10127b4a */
            ii(0x1012_7b16, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1012_7b1a, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7b1c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_7b1e, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b23, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7b25, 7); mov(ax, memw[ds, eax + 0x4dc]);         /* mov ax, [eax+0x4dc] */
            ii(0x1012_7b2c, 4); cmp(ax, memw[ss, ebp - 0x40]);          /* cmp ax, [ebp-0x40] */
            ii(0x1012_7b30, 2); if(jnz(0x1012_7b48, 0x16)) goto l_0x1012_7b48; /* jnz 0x10127b48 */
            ii(0x1012_7b32, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1012_7b36, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b3b, 5); call(0x1011_3129, -0x1_4a17);           /* call 0x10113129 */
            ii(0x1012_7b40, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b45, 3); dec(memb[ds, eax + 0xf]);               /* dec byte [eax+0xf] */
        l_0x1012_7b48:
            ii(0x1012_7b48, 2); jmp(0x1012_7b0c, -0x3e); goto l_0x1012_7b0c; /* jmp 0x10127b0c */
        l_0x1012_7b4a:
            ii(0x1012_7b4a, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_7b4d, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1012_7b51, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x1012_7b54, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1012_7b58, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1012_7b5a, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b5f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_7b61, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x1012_7b64, 7); mov(memw[ds, edx + 0x4dc], ax);         /* mov [edx+0x4dc], ax */
            ii(0x1012_7b6b, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b70, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x1012_7b74, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1012_7b76, 3); mov(eax, memd[ss, ebp - 0x3c]);         /* mov eax, [ebp-0x3c] */
            ii(0x1012_7b79, 3); mov(al, memb[ds, eax + 0x4]);           /* mov al, [eax+0x4] */
            ii(0x1012_7b7c, 6); mov(memb[ds, edx + 0x4ec], al);         /* mov [edx+0x4ec], al */
            ii(0x1012_7b82, 3); mov(edx, memd[ss, ebp - 0x3c]);         /* mov edx, [ebp-0x3c] */
            ii(0x1012_7b85, 3); add(edx, 0x5);                          /* add edx, 0x5 */
            ii(0x1012_7b88, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x1012_7b8c, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1012_7b8f, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7b94, 5); add(eax, 0x338);                        /* add eax, 0x338 */
            ii(0x1012_7b99, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_7b9b, 5); call(Definitions.sys_strcpy, 0x3_e32f); /* call 0x10165ecf */
            ii(0x1012_7ba0, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7ba5, 3); inc(memb[ds, eax + 0xf]);               /* inc byte [eax+0xf] */
            ii(0x1012_7ba8, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7bad, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7bb1:
            ii(0x1012_7bb1, 5); jmp(0x1012_85f4, 0xa3e); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7bb6:
            ii(0x1012_7bb6, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7bbd, 6); if(jnz(0x1012_7c6d, 0xaa)) goto l_0x1012_7c6d; /* jnz 0x10127c6d */
            ii(0x1012_7bc3, 7); mov(memd[ss, ebp - 0x48], 0x8);         /* mov dword [ebp-0x48], 0x8 */
        l_0x1012_7bca:
            ii(0x1012_7bca, 3); dec(memd[ss, ebp - 0x48]);              /* dec dword [ebp-0x48] */
            ii(0x1012_7bcd, 5); cmp(memw[ss, ebp - 0x48], -0x1 /* 0xff */); /* cmp word [ebp-0x48], 0xffff */
            ii(0x1012_7bd2, 2); if(jz(0x1012_7c18, 0x44)) goto l_0x1012_7c18; /* jz 0x10127c18 */
            ii(0x1012_7bd4, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x1012_7bd8, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7bda, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_7bdc, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7be1, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7be3, 7); mov(ax, memw[ds, eax + 0x328]);         /* mov ax, [eax+0x328] */
            ii(0x1012_7bea, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7bee, 2); if(jnz(0x1012_7c16, 0x26)) goto l_0x1012_7c16; /* jnz 0x10127c16 */
            ii(0x1012_7bf0, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7bf5, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x1012_7bf9, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1012_7bfc, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c01, 5); add(eax, 0x238);                        /* add eax, 0x238 */
            ii(0x1012_7c06, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_7c08, 5); call(Definitions.sys_strcpy, 0x3_e2c2); /* call 0x10165ecf */
            ii(0x1012_7c0d, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c12, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7c16:
            ii(0x1012_7c16, 2); jmp(0x1012_7bca, -0x4e); goto l_0x1012_7bca; /* jmp 0x10127bca */
        l_0x1012_7c18:
            ii(0x1012_7c18, 7); mov(memd[ss, ebp - 0x48], 0x4);         /* mov dword [ebp-0x48], 0x4 */
        l_0x1012_7c1f:
            ii(0x1012_7c1f, 3); dec(memd[ss, ebp - 0x48]);              /* dec dword [ebp-0x48] */
            ii(0x1012_7c22, 5); cmp(memw[ss, ebp - 0x48], -0x1 /* 0xff */); /* cmp word [ebp-0x48], 0xffff */
            ii(0x1012_7c27, 2); if(jz(0x1012_7c6d, 0x44)) goto l_0x1012_7c6d; /* jz 0x10127c6d */
            ii(0x1012_7c29, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x1012_7c2d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1012_7c2f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_7c31, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c36, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_7c38, 7); mov(ax, memw[ds, eax + 0x4dc]);         /* mov ax, [eax+0x4dc] */
            ii(0x1012_7c3f, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7c43, 2); if(jnz(0x1012_7c6b, 0x26)) goto l_0x1012_7c6b; /* jnz 0x10127c6b */
            ii(0x1012_7c45, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7c4a, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x1012_7c4e, 3); imul(ebx, eax, 0x1e);                   /* imul ebx, eax, 0x1e */
            ii(0x1012_7c51, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c56, 5); add(eax, 0x338);                        /* add eax, 0x338 */
            ii(0x1012_7c5b, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1012_7c5d, 5); call(Definitions.sys_strcpy, 0x3_e26d); /* call 0x10165ecf */
            ii(0x1012_7c62, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c67, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7c6b:
            ii(0x1012_7c6b, 2); jmp(0x1012_7c1f, -0x4e); goto l_0x1012_7c1f; /* jmp 0x10127c1f */
        l_0x1012_7c6d:
            ii(0x1012_7c6d, 5); jmp(0x1012_85f4, 0x982); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7c72:
            ii(0x1012_7c72, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7c79, 2); if(jnz(0x1012_7c8a, 0xf)) goto l_0x1012_7c8a; /* jnz 0x10127c8a */
            ii(0x1012_7c7b, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c80, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_7c84, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7c88, 2); if(jz(0x1012_7c8c, 0x2)) goto l_0x1012_7c8c; /* jz 0x10127c8c */
        l_0x1012_7c8a:
            ii(0x1012_7c8a, 2); jmp(0x1012_7cae, 0x22); goto l_0x1012_7cae; /* jmp 0x10127cae */
        l_0x1012_7c8c:
            ii(0x1012_7c8c, 5); mov(ebx, 0xad);                         /* mov ebx, 0xad */
            ii(0x1012_7c91, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7c96, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7c9b, 5); add(eax, 0x4f0);                        /* add eax, 0x4f0 */
            ii(0x1012_7ca0, 5); call(Definitions.sys_memcpy, 0x3_e1a6); /* call 0x10165e4b */
            ii(0x1012_7ca5, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7caa, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7cae:
            ii(0x1012_7cae, 5); jmp(0x1012_85f4, 0x941); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7cb3:
            ii(0x1012_7cb3, 7); cmp(memb[ds, 0x101c_5630], 0x1);        /* cmp byte [0x101c5630], 0x1 */
            ii(0x1012_7cba, 2); if(jnz(0x1012_7ccb, 0xf)) goto l_0x1012_7ccb; /* jnz 0x10127ccb */
            ii(0x1012_7cbc, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7cc1, 4); mov(ax, memw[ds, eax + 0xc]);           /* mov ax, [eax+0xc] */
            ii(0x1012_7cc5, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x1012_7cc9, 2); if(jz(0x1012_7ccd, 0x2)) goto l_0x1012_7ccd; /* jz 0x10127ccd */
        l_0x1012_7ccb:
            ii(0x1012_7ccb, 2); jmp(0x1012_7cea, 0x1d); goto l_0x1012_7cea; /* jmp 0x10127cea */
        l_0x1012_7ccd:
            ii(0x1012_7ccd, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7cd2, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7cd7, 5); add(eax, 0x446);                        /* add eax, 0x446 */
            ii(0x1012_7cdc, 5); call(Definitions.sys_strcpy, 0x3_e1ee); /* call 0x10165ecf */
            ii(0x1012_7ce1, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7ce6, 4); mov(memb[ds, eax + 0xe], 0x1);          /* mov byte [eax+0xe], 0x1 */
        l_0x1012_7cea:
            ii(0x1012_7cea, 5); jmp(0x1012_85f4, 0x905); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7cef:
            ii(0x1012_7cef, 7); mov(memd[ss, ebp - 0x4c], 0x101c_59f5); /* mov dword [ebp-0x4c], 0x101c59f5 */
            ii(0x1012_7cf6, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1012_7cfb, 3); mov(edx, memd[ss, ebp - 0x4c]);         /* mov edx, [ebp-0x4c] */
            ii(0x1012_7cfe, 3); add(edx, 0x4);                          /* add edx, 0x4 */
            ii(0x1012_7d01, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x1012_7d04, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1012_7d07, 3); imul(eax, eax, 0x6);                    /* imul eax, eax, 0x6 */
            ii(0x1012_7d0a, 5); mov(ecx, 0x101c_4090);                  /* mov ecx, 0x101c4090 */
            ii(0x1012_7d0f, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1012_7d11, 5); call(Definitions.sys_memcpy, 0x3_e135); /* call 0x10165e4b */
            ii(0x1012_7d16, 5); mov(eax, memd[ds, 0x101c_59cc]);        /* mov eax, [0x101c59cc] */
            ii(0x1012_7d1b, 3); inc(memb[ds, eax + 0xf]);               /* inc byte [eax+0xf] */
            ii(0x1012_7d1e, 5); jmp(0x1012_85f4, 0x8d1); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7d23:
            ii(0x1012_7d23, 7); mov(memd[ss, ebp - 0x50], 0x101c_59f5); /* mov dword [ebp-0x50], 0x101c59f5 */
            ii(0x1012_7d2a, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1012_7d2f, 3); mov(edx, memd[ss, ebp - 0x50]);         /* mov edx, [ebp-0x50] */
            ii(0x1012_7d32, 5); mov(eax, 0x101c_4090);                  /* mov eax, 0x101c4090 */
            ii(0x1012_7d37, 5); call(Definitions.sys_memcpy, 0x3_e10f); /* call 0x10165e4b */
            ii(0x1012_7d3c, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_7d42, 4); mov(memb[ds, edx + 0xa], 0x1);          /* mov byte [edx+0xa], 0x1 */
            ii(0x1012_7d46, 5); jmp(0x1012_85f4, 0x8a9); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7d4b:
            ii(0x1012_7d4b, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7d4f, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_7d55, 6); mov(memb[ds, eax + 0x101c_59c0], dl);   /* mov [eax+0x101c59c0], dl */
            ii(0x1012_7d5b, 5); jmp(0x1012_85f4, 0x894); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7d60:
            ii(0x1012_7d60, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7d64, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_7d6a, 7); mov(memb[ds, eax + 0x101c_a491], 0x1);  /* mov byte [eax+0x101ca491], 0x1 */
            ii(0x1012_7d71, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7d73, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x1012_7d78, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7d7a, 6); if(jz(0x1012_7e7f, 0xff)) goto l_0x1012_7e7f; /* jz 0x10127e7f */
            ii(0x1012_7d80, 4); mov(memb[ss, ebp - 0x54], 0);           /* mov byte [ebp-0x54], 0x0 */
            ii(0x1012_7d84, 7); mov(memd[ss, ebp - 0x58], 0);           /* mov dword [ebp-0x58], 0x0 */
            ii(0x1012_7d8b, 2); jmp(0x1012_7d93, 0x6); goto l_0x1012_7d93; /* jmp 0x10127d93 */
        l_0x1012_7d8d:
            ii(0x1012_7d8d, 3); mov(eax, memd[ss, ebp - 0x58]);         /* mov eax, [ebp-0x58] */
            ii(0x1012_7d90, 3); inc(memd[ss, ebp - 0x58]);              /* inc dword [ebp-0x58] */
        l_0x1012_7d93:
            ii(0x1012_7d93, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1012_7d97, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_7d9a, 2); if(jge(0x1012_7df0, 0x54)) goto l_0x1012_7df0; /* jge 0x10127df0 */
            ii(0x1012_7d9c, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1012_7da0, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_7da6, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_7dac, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_7db1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7db3, 2); if(jz(0x1012_7dcf, 0x1a)) goto l_0x1012_7dcf; /* jz 0x10127dcf */
            ii(0x1012_7db5, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1012_7db9, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_7dbf, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1012_7dc5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_7dca, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_7dcd, 2); if(jnz(0x1012_7dd1, 0x2)) goto l_0x1012_7dd1; /* jnz 0x10127dd1 */
        l_0x1012_7dcf:
            ii(0x1012_7dcf, 2); jmp(0x1012_7dee, 0x1d); goto l_0x1012_7dee; /* jmp 0x10127dee */
        l_0x1012_7dd1:
            ii(0x1012_7dd1, 4); movsx(eax, memw[ss, ebp - 0x58]);       /* movsx eax, word [ebp-0x58] */
            ii(0x1012_7dd5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_7ddb, 6); mov(al, memb[ds, eax + 0x101c_a491]);   /* mov al, [eax+0x101ca491] */
            ii(0x1012_7de1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_7de6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7de8, 2); if(jnz(0x1012_7dee, 0x4)) goto l_0x1012_7dee; /* jnz 0x10127dee */
            ii(0x1012_7dea, 4); mov(memb[ss, ebp - 0x54], 0x1);         /* mov byte [ebp-0x54], 0x1 */
        l_0x1012_7dee:
            ii(0x1012_7dee, 2); jmp(0x1012_7d8d, -0x63); goto l_0x1012_7d8d; /* jmp 0x10127d8d */
        l_0x1012_7df0:
            ii(0x1012_7df0, 5); call(0x1010_2912, -0x2_54e3);           /* call 0x10102912 */
            ii(0x1012_7df5, 4); cmp(memb[ss, ebp - 0x54], 0);           /* cmp byte [ebp-0x54], 0x0 */
            ii(0x1012_7df9, 6); if(jz(0x1012_7e7d, 0x7e)) goto l_0x1012_7e7d; /* jz 0x10127e7d */
            ii(0x1012_7dff, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1012_7e03, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1012_7e06, 6); push(memd[ds, edx + 0x101b_b444]);      /* push dword [edx+0x101bb444] */
            ii(0x1012_7e0c, 5); mov(eax, StringDefinitions.SHasEndedTurn); /* mov eax, 0x101a82c6 */
            ii(0x1012_7e11, 1); push(eax);                              /* push eax */
            ii(0x1012_7e12, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_7e17, 1); push(eax);                              /* push eax */
            ii(0x1012_7e18, 5); call(Definitions.sys_sprintf, 0x3_e0e4); /* call 0x10165f01 */
            ii(0x1012_7e1d, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_7e20, 5); call(0x100c_aa00, -0x5_d425);           /* call 0x100caa00 */
            ii(0x1012_7e25, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_7e2a, 1); push(eax);                              /* push eax */
            ii(0x1012_7e2b, 5); call(0x100c_aa20, -0x5_d410);           /* call 0x100caa20 */
            ii(0x1012_7e30, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_7e32, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_7e34, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_7e39, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_7e3e, 5); call(0x1011_5d23, -0x1_2120);           /* call 0x10115d23 */
            ii(0x1012_7e43, 7); mov(memd[ss, ebp - 0x5c], 0x1);         /* mov dword [ebp-0x5c], 0x1 */
            ii(0x1012_7e4a, 3); mov(eax, memd[ss, ebp - 0x5c]);         /* mov eax, [ebp-0x5c] */
            ii(0x1012_7e4d, 1); inc(eax);                               /* inc eax */
            ii(0x1012_7e4e, 4); imul(eax, memd[ss, ebp - 0x14]);        /* imul eax, [ebp-0x14] */
            ii(0x1012_7e52, 5); add(eax, 0x413);                        /* add eax, 0x413 */
            ii(0x1012_7e57, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x1012_7e5a, 3); mov(eax, memd[ss, ebp - 0x60]);         /* mov eax, [ebp-0x60] */
            ii(0x1012_7e5d, 3); add(eax, memd[ss, ebp - 0x5c]);         /* add eax, [ebp-0x5c] */
            ii(0x1012_7e60, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x1012_7e63, 5); call(0x100d_5470, -0x5_29f8);           /* call 0x100d5470 */
            ii(0x1012_7e68, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_7e6b, 4); movsx(ebx, memw[ss, ebp - 0x64]);       /* movsx ebx, word [ebp-0x64] */
            ii(0x1012_7e6f, 4); movsx(edx, memw[ss, ebp - 0x60]);       /* movsx edx, word [ebp-0x60] */
            ii(0x1012_7e73, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_7e78, 5); call(0x1013_daea, 0x1_5c6d);            /* call 0x1013daea */
        l_0x1012_7e7d:
            ii(0x1012_7e7d, 2); jmp(0x1012_7e86, 0x7); goto l_0x1012_7e86; /* jmp 0x10127e86 */
        l_0x1012_7e7f:
            ii(0x1012_7e7f, 7); mov(memb[ds, 0x101c_391e], 0x9);        /* mov byte [0x101c391e], 0x9 */
        l_0x1012_7e86:
            ii(0x1012_7e86, 5); jmp(0x1012_85f4, 0x769); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7e8b:
            ii(0x1012_7e8b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7e8d, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_7e92, 6); inc(memb[ds, eax + 0x101c_59d8]);       /* inc byte [eax+0x101c59d8] */
            ii(0x1012_7e98, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7e9a, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_7e9f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_7ea1, 6); mov(bl, memb[ds, eax + 0x101c_59d8]);   /* mov bl, [eax+0x101c59d8] */
            ii(0x1012_7ea7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_7ea9, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1012_7eae, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_7eb1, 5); mov(eax, 0x30);                         /* mov eax, 0x30 */
            ii(0x1012_7eb6, 5); call(0x1012_8897, 0x9dc);               /* call 0x10128897 */
            ii(0x1012_7ebb, 7); cmp(memb[ds, 0x101c_59f6], 0);          /* cmp byte [0x101c59f6], 0x0 */
            ii(0x1012_7ec2, 2); if(jz(0x1012_7ed1, 0xd)) goto l_0x1012_7ed1; /* jz 0x10127ed1 */
            ii(0x1012_7ec4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_7ec6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_7ec8, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7ecc, 5); call(0x1012_748f, -0xa42);              /* call 0x1012748f */
        l_0x1012_7ed1:
            ii(0x1012_7ed1, 5); jmp(0x1012_85f4, 0x71e); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7ed6:
            ii(0x1012_7ed6, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7eda, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_7ee0, 6); mov(memb[ds, eax + 0x101c_59d8], dl);   /* mov [eax+0x101c59d8], dl */
            ii(0x1012_7ee6, 5); jmp(0x1012_85f4, 0x709); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7eeb:
            ii(0x1012_7eeb, 7); mov(memb[ds, 0x101c_609e], 0x1);        /* mov byte [0x101c609e], 0x1 */
            ii(0x1012_7ef2, 5); jmp(0x1012_85f4, 0x6fd); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7ef7:
            ii(0x1012_7ef7, 7); mov(memd[ss, ebp - 0x68], 0x101c_59f5); /* mov dword [ebp-0x68], 0x101c59f5 */
            ii(0x1012_7efe, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_7f01, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1012_7f04, 2); if(jz(0x1012_7f0d, 0x7)) goto l_0x1012_7f0d; /* jz 0x10127f0d */
            ii(0x1012_7f06, 7); mov(memb[ds, 0x101c_8170], 0x1);        /* mov byte [0x101c8170], 0x1 */
        l_0x1012_7f0d:
            ii(0x1012_7f0d, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_7f10, 3); mov(eax, memd[ds, eax + 0x1]);          /* mov eax, [eax+0x1] */
            ii(0x1012_7f13, 6); cmp(eax, memd[ds, 0x101c_816c]);        /* cmp eax, [0x101c816c] */
            ii(0x1012_7f19, 2); if(jle(0x1012_7f2f, 0x14)) goto l_0x1012_7f2f; /* jle 0x10127f2f */
            ii(0x1012_7f1b, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_7f1e, 6); mov(memw[ds, 0x101c_8168], ax);         /* mov [0x101c8168], ax */
            ii(0x1012_7f24, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x1012_7f27, 3); mov(eax, memd[ds, eax + 0x1]);          /* mov eax, [eax+0x1] */
            ii(0x1012_7f2a, 5); mov(memd[ds, 0x101c_816c], eax);        /* mov [0x101c816c], eax */
        l_0x1012_7f2f:
            ii(0x1012_7f2f, 5); jmp(0x1012_85f4, 0x6c0); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7f34:
            ii(0x1012_7f34, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_7f36, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_7f3a, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_7f3f, 5); call(0x1010_3eba, -0x2_408a);           /* call 0x10103eba */
            ii(0x1012_7f44, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_7f47, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_7f4b, 2); if(jnz(0x1012_7f58, 0xb)) goto l_0x1012_7f58; /* jnz 0x10127f58 */
            ii(0x1012_7f4d, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7f51, 5); call(0x1012_6a47, -0x150f);             /* call 0x10126a47 */
            ii(0x1012_7f56, 2); jmp(0x1012_7f7f, 0x27); goto l_0x1012_7f7f; /* jmp 0x10127f7f */
        l_0x1012_7f58:
            ii(0x1012_7f58, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7f5d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_7f60, 5); call(0x1012_5dd6, -0x218f);             /* call 0x10125dd6 */
            ii(0x1012_7f65, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_7f68, 3); mov(ebx, memd[ds, eax + 0x3a]);         /* mov ebx, [eax+0x3a] */
            ii(0x1012_7f6b, 3); sar(ebx, 0x18);                         /* sar ebx, 0x18 */
            ii(0x1012_7f6e, 3); shl(ebx, 0x3);                          /* shl ebx, 0x3 */
            ii(0x1012_7f71, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7f76, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_7f79, 6); call_abs(memd[ds, ebx + 0x101c_60a4]);  /* call dword [ebx+0x101c60a4] */
        l_0x1012_7f7f:
            ii(0x1012_7f7f, 5); jmp(0x1012_85f4, 0x670); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7f84:
            ii(0x1012_7f84, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7f88, 5); call(0x1012_6c9d, -0x12f0);             /* call 0x10126c9d */
            ii(0x1012_7f8d, 5); jmp(0x1012_85f4, 0x662); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7f92:
            ii(0x1012_7f92, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7f96, 5); call(0x1012_686a, -0x1731);             /* call 0x1012686a */
            ii(0x1012_7f9b, 5); jmp(0x1012_85f4, 0x654); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7fa0:
            ii(0x1012_7fa0, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7fa4, 5); call(0x1012_6a9c, -0x150d);             /* call 0x10126a9c */
            ii(0x1012_7fa9, 5); jmp(0x1012_85f4, 0x646); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7fae:
            ii(0x1012_7fae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_7fb0, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_7fb4, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_7fb9, 5); call(0x1010_3eba, -0x2_4104);           /* call 0x10103eba */
            ii(0x1012_7fbe, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x1012_7fc1, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1012_7fc5, 2); if(jnz(0x1012_7fd2, 0xb)) goto l_0x1012_7fd2; /* jnz 0x10127fd2 */
            ii(0x1012_7fc7, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7fcb, 5); call(0x1012_6a47, -0x1589);             /* call 0x10126a47 */
            ii(0x1012_7fd0, 2); jmp(0x1012_7fdf, 0xd); goto l_0x1012_7fdf; /* jmp 0x10127fdf */
        l_0x1012_7fd2:
            ii(0x1012_7fd2, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7fd7, 3); mov(eax, memd[ss, ebp - 0x6c]);         /* mov eax, [ebp-0x6c] */
            ii(0x1012_7fda, 5); call(0x1015_1d25, 0x2_9d46);            /* call 0x10151d25 */
        l_0x1012_7fdf:
            ii(0x1012_7fdf, 5); jmp(0x1012_85f4, 0x610); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_7fe4:
            ii(0x1012_7fe4, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_7fe9, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_7fed, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_7ff3, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1012_7ff9, 5); call(0x100d_f5ba, -0x4_8a44);           /* call 0x100df5ba */
            ii(0x1012_7ffe, 5); jmp(0x1012_85f4, 0x5f1); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_8003:
            ii(0x1012_8003, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8005, 5); mov(al, memb[ds, 0x101c_59f0]);         /* mov al, [0x101c59f0] */
            ii(0x1012_800a, 3); cmp(eax, 0x2a);                         /* cmp eax, 0x2a */
            ii(0x1012_800d, 2); if(jnz(0x1012_8015, 0x6)) goto l_0x1012_8015; /* jnz 0x10128015 */
            ii(0x1012_800f, 4); mov(memb[ss, ebp - 0x70], 0x1);         /* mov byte [ebp-0x70], 0x1 */
            ii(0x1012_8013, 2); jmp(0x1012_8019, 0x4); goto l_0x1012_8019; /* jmp 0x10128019 */
        l_0x1012_8015:
            ii(0x1012_8015, 4); mov(memb[ss, ebp - 0x70], 0);           /* mov byte [ebp-0x70], 0x0 */
        l_0x1012_8019:
            ii(0x1012_8019, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_801b, 3); mov(dl, memb[ss, ebp - 0x70]);          /* mov dl, [ebp-0x70] */
            ii(0x1012_801e, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_8022, 5); call(0x1012_6727, -0x1900);             /* call 0x10126727 */
            ii(0x1012_8027, 5); jmp(0x1012_85f4, 0x5c8); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_802c:
            ii(0x1012_802c, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1012_8030, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_8035, 5); mov(eax, 0x101c_5628);                  /* mov eax, 0x101c5628 */
            ii(0x1012_803a, 5); call(Definitions.sys_memcpy, 0x3_de0c); /* call 0x10165e4b */
            ii(0x1012_803f, 5); jmp(0x1012_85f4, 0x5b0); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_8044:
            ii(0x1012_8044, 7); mov(memd[ss, ebp - 0x74], 0x101c_59f5); /* mov dword [ebp-0x74], 0x101c59f5 */
            ii(0x1012_804b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_804d, 5); mov(al, memb[ds, 0x101c_37d4]);         /* mov al, [0x101c37d4] */
            ii(0x1012_8052, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x1012_8055, 7); mov(memb[ds, 0x101c_37d4], 0x1);        /* mov byte [0x101c37d4], 0x1 */
            ii(0x1012_805c, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1012_805f, 3); mov(ecx, memd[ds, eax + 0x2]);          /* mov ecx, [eax+0x2] */
            ii(0x1012_8062, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1012_8065, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1012_8068, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1012_806a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_806d, 3); mov(eax, memd[ss, ebp - 0x74]);         /* mov eax, [ebp-0x74] */
            ii(0x1012_8070, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_8073, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_8077, 5); call(0x1010_2119, -0x2_5f63);           /* call 0x10102119 */
            ii(0x1012_807c, 3); mov(al, memb[ss, ebp - 0x78]);          /* mov al, [ebp-0x78] */
            ii(0x1012_807f, 5); mov(memb[ds, 0x101c_37d4], al);         /* mov [0x101c37d4], al */
            ii(0x1012_8084, 5); jmp(0x1012_85f4, 0x56b); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_8089:
            ii(0x1012_8089, 7); mov(memd[ss, ebp - 0x7c], 0x101c_59f5); /* mov dword [ebp-0x7c], 0x101c59f5 */
            ii(0x1012_8090, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_8095, 3); mov(edx, memd[ss, ebp - 0x7c]);         /* mov edx, [ebp-0x7c] */
            ii(0x1012_8098, 3); add(edx, 0x1e);                         /* add edx, 0x1e */
            ii(0x1012_809b, 3); mov(eax, memd[ss, ebp - 0x7c]);         /* mov eax, [ebp-0x7c] */
            ii(0x1012_809e, 5); call(0x1013_6e81, 0xedde);              /* call 0x10136e81 */
            ii(0x1012_80a3, 5); call(0x100c_aa00, -0x5_d6a8);           /* call 0x100caa00 */
            ii(0x1012_80a8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_80ad, 1); push(eax);                              /* push eax */
            ii(0x1012_80ae, 5); call(0x100c_aa20, -0x5_d693);           /* call 0x100caa20 */
            ii(0x1012_80b3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_80b5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_80b7, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_80bc, 5); mov(eax, StringDefinitions.GameSaved2); /* mov eax, 0x101a82d9 */
            ii(0x1012_80c1, 5); call(0x1011_5d23, -0x1_23a3);           /* call 0x10115d23 */
            ii(0x1012_80c6, 5); jmp(0x1012_85f4, 0x529); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_80cb:
            ii(0x1012_80cb, 5); call(0x1012_6d5a, -0x1376);             /* call 0x10126d5a */
            ii(0x1012_80d0, 5); jmp(0x1012_85f4, 0x51f); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_80d5:
            ii(0x1012_80d5, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_80da, 5); mov(ebx, 0x101c_5e74);                  /* mov ebx, 0x101c5e74 */
            ii(0x1012_80df, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_80e2, 2); add(al, 0x63);                          /* add al, 0x63 */
            ii(0x1012_80e4, 3); movsx(edx, al);                         /* movsx edx, al */
            ii(0x1012_80e7, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_80ec, 5); call(0x1010_6281, -0x2_1e70);           /* call 0x10106281 */
            ii(0x1012_80f1, 5); mov(edx, StringDefinitions.Control43);  /* mov edx, 0x101a82e5 */
            ii(0x1012_80f6, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_80fb, 5); call(Definitions.sys_strcat, 0x3_de31); /* call 0x10165f31 */
            ii(0x1012_8100, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_8105, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_810a, 5); call(Definitions.sys_strcat, 0x3_de22); /* call 0x10165f31 */
            ii(0x1012_810f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_8111, 1); push(eax);                              /* push eax */
            ii(0x1012_8112, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_8117, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_8119, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_811e, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_8123, 5); call(0x1011_5d23, -0x1_2405);           /* call 0x10115d23 */
            ii(0x1012_8128, 5); mov(edx, 0x295);                        /* mov edx, 0x295 */
            ii(0x1012_812d, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_8132, 5); call(0x1011_5c5f, -0x1_24d8);           /* call 0x10115c5f */
            ii(0x1012_8137, 5); jmp(0x1012_85f4, 0x4b8); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_813c:
            ii(0x1012_813c, 7); mov(memd[ss, ebp - 0x80], 0x101c_59f5); /* mov dword [ebp-0x80], 0x101c59f5 */
            ii(0x1012_8143, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1012_8146, 3); mov(ecx, memd[ds, eax + 0x4]);          /* mov ecx, [eax+0x4] */
            ii(0x1012_8149, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1012_814c, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1012_814f, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1012_8152, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_8155, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1012_8158, 2); mov(esi, memd[ds, eax]);                /* mov esi, [eax] */
            ii(0x1012_815a, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1012_815d, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1012_8160, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1012_8163, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_8167, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_816d, 6); mov(eax, memd[ds, eax + 0x101c_a562]);  /* mov eax, [eax+0x101ca562] */
            ii(0x1012_8173, 5); call(0x100d_f329, -0x4_8e4f);           /* call 0x100df329 */
            ii(0x1012_8178, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1012_817a, 5); call(0x100d_7a9c, -0x5_06e3);           /* call 0x100d7a9c */
            ii(0x1012_817f, 5); jmp(0x1012_85f4, 0x470); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_8184:
            ii(0x1012_8184, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1012_8187, 6); mov(memw[ds, 0x101c_59ee], ax);         /* mov [0x101c59ee], ax */
            ii(0x1012_818d, 4); movsx(ebx, memw[ss, ebp - 0x10]);       /* movsx ebx, word [ebp-0x10] */
            ii(0x1012_8191, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_8196, 5); mov(eax, 0x101c_5e48);                  /* mov eax, 0x101c5e48 */
            ii(0x1012_819b, 5); call(Definitions.sys_memcpy, 0x3_dcab); /* call 0x10165e4b */
            ii(0x1012_81a0, 5); jmp(0x1012_85f4, 0x44f); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_81a5:
            ii(0x1012_81a5, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_81a9, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_81af, 6); mov(memb[ds, eax + 0x101c_59e0], dl);   /* mov [eax+0x101c59e0], dl */
            ii(0x1012_81b5, 5); jmp(0x1012_85f4, 0x43a); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_81ba:
            ii(0x1012_81ba, 7); mov(memb[ds, 0x101c_59ec], 0x1);        /* mov byte [0x101c59ec], 0x1 */
            ii(0x1012_81c1, 5); jmp(0x1012_85f4, 0x42e); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_81c6:
            ii(0x1012_81c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_81c8, 6); mov(dl, memb[ds, 0x101c_59f5]);         /* mov dl, [0x101c59f5] */
            ii(0x1012_81ce, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_81d1, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1012_81d3, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1012_81d6, 5); call(0x100c_aafc, -0x5_d6df);           /* call 0x100caafc */
            ii(0x1012_81db, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_81df, 5); call(0x1013_602e, 0xde4a);              /* call 0x1013602e */
            ii(0x1012_81e4, 5); jmp(0x1012_85f4, 0x40b); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_81e9:
            ii(0x1012_81e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_81eb, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_81ef, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_81f4, 5); call(0x1010_3eba, -0x2_433f);           /* call 0x10103eba */
            ii(0x1012_81f9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_81fc, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_8200, 2); if(jnz(0x1012_8210, 0xe)) goto l_0x1012_8210; /* jnz 0x10128210 */
            ii(0x1012_8202, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_8206, 5); call(0x1012_6a47, -0x17c4);             /* call 0x10126a47 */
            ii(0x1012_820b, 5); jmp(0x1012_8436, 0x226); goto l_0x1012_8436; /* jmp 0x10128436 */
        l_0x1012_8210:
            ii(0x1012_8210, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8212, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8215, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_8218, 5); call(0x1013_ad71, 0x1_2b54);            /* call 0x1013ad71 */
            ii(0x1012_821d, 2); test(al, al);                           /* test al, al */
            ii(0x1012_821f, 2); if(jz(0x1012_822e, 0xd)) goto l_0x1012_822e; /* jz 0x1012822e */
            ii(0x1012_8221, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8223, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8226, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_8229, 5); call(0x1007_6a34, -0xb_17fa);           /* call 0x10076a34 */
        l_0x1012_822e:
            ii(0x1012_822e, 10); mov(memd[ss, ebp - 0x84], 0x101c_59f5); /* mov dword [ebp-0x84], 0x101c59f5 */
            ii(0x1012_8238, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_823b, 5); call(0x1016_186c, 0x3_962c);            /* call 0x1016186c */
            ii(0x1012_8240, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8246, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1012_8248, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_824b, 3); mov(memb[ds, eax + 0x3d], dl);          /* mov [eax+0x3d], dl */
            ii(0x1012_824e, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8254, 3); mov(dl, memb[ds, eax + 0x1]);           /* mov dl, [eax+0x1] */
            ii(0x1012_8257, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_825a, 3); mov(memb[ds, eax + 0x3e], dl);          /* mov [eax+0x3e], dl */
            ii(0x1012_825d, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8263, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x1012_8267, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_826a, 4); mov(memw[ds, eax + 0x41], dx);          /* mov [eax+0x41], dx */
            ii(0x1012_826e, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8274, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x1012_8278, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_827b, 4); mov(memw[ds, eax + 0x43], dx);          /* mov [eax+0x43], dx */
            ii(0x1012_827f, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8285, 3); mov(dl, memb[ds, eax + 0x14]);          /* mov dl, [eax+0x14] */
            ii(0x1012_8288, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_828b, 3); mov(memb[ds, eax + 0x4f], dl);          /* mov [eax+0x4f], dl */
            ii(0x1012_828e, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8294, 5); cmp(memw[ds, eax + 0x18], 0);           /* cmp word [eax+0x18], 0x0 */
            ii(0x1012_8299, 6); if(jz(0x1012_842e, 0x18f)) goto l_0x1012_842e; /* jz 0x1012842e */
            ii(0x1012_829f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_82a2, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x1012_82a6, 6); if(jz(0x1012_8383, 0xd7)) goto l_0x1012_8383; /* jz 0x10128383 */
            ii(0x1012_82ac, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_82af, 5); call(0x1015_48ba, 0x2_c606);            /* call 0x101548ba */
            ii(0x1012_82b4, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1012_82b9, 5); call(Definitions.sys_new, 0x3_db42);    /* call 0x10165e00 */
            ii(0x1012_82be, 6); mov(memd[ss, ebp - 0x88], eax);         /* mov [ebp-0x88], eax */
            ii(0x1012_82c4, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x1012_82ca, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
            ii(0x1012_82d0, 7); cmp(memd[ss, ebp - 0x8c], 0);           /* cmp dword [ebp-0x8c], 0x0 */
            ii(0x1012_82d7, 2); if(jz(0x1012_8334, 0x5b)) goto l_0x1012_8334; /* jz 0x10128334 */
            ii(0x1012_82d9, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_82df, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1012_82e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_82e5, 1); push(eax);                              /* push eax */
            ii(0x1012_82e6, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_82ec, 3); mov(eax, memd[ds, eax + 0x4]);          /* mov eax, [eax+0x4] */
            ii(0x1012_82ef, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_82f2, 1); push(eax);                              /* push eax */
            ii(0x1012_82f3, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_82f9, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x1012_82fc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_82ff, 1); push(eax);                              /* push eax */
            ii(0x1012_8300, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8306, 3); mov(ecx, memd[ds, eax + 0xe]);          /* mov ecx, [eax+0xe] */
            ii(0x1012_8309, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_830f, 3); mov(ebx, memd[ds, eax + 0xa]);          /* mov ebx, [eax+0xa] */
            ii(0x1012_8312, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_8315, 6); mov(eax, memd[ss, ebp - 0x88]);         /* mov eax, [ebp-0x88] */
            ii(0x1012_831b, 5); call(0x1011_833b, -0xffe5);             /* call 0x1011833b */
            ii(0x1012_8320, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
            ii(0x1012_8326, 6); mov(eax, memd[ss, ebp - 0x90]);         /* mov eax, [ebp-0x90] */
            ii(0x1012_832c, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x1012_8332, 2); jmp(0x1012_8340, 0xc); goto l_0x1012_8340; /* jmp 0x10128340 */
        l_0x1012_8334:
            ii(0x1012_8334, 6); mov(eax, memd[ss, ebp - 0x8c]);         /* mov eax, [ebp-0x8c] */
            ii(0x1012_833a, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
        l_0x1012_8340:
            ii(0x1012_8340, 6); mov(edx, memd[ss, ebp - 0x94]);         /* mov edx, [ebp-0x94] */
            ii(0x1012_8346, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8349, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_834c, 5); call(0x1007_6a34, -0xb_191d);           /* call 0x10076a34 */
            ii(0x1012_8351, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8357, 3); mov(dl, memb[ds, eax + 0x17]);          /* mov dl, [eax+0x17] */
            ii(0x1012_835a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_835d, 3); mov(memb[ds, eax + 0x2a], dl);          /* mov [eax+0x2a], dl */
            ii(0x1012_8360, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8366, 3); mov(dl, memb[ds, eax + 0x15]);          /* mov dl, [eax+0x15] */
            ii(0x1012_8369, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_836c, 3); mov(memb[ds, eax + 0x4e], dl);          /* mov [eax+0x4e], dl */
            ii(0x1012_836f, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_8375, 3); mov(dl, memb[ds, eax + 0x16]);          /* mov dl, [eax+0x16] */
            ii(0x1012_8378, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_837b, 3); mov(memb[ds, eax + 0x64], dl);          /* mov [eax+0x64], dl */
            ii(0x1012_837e, 5); jmp(0x1012_842e, 0xab); goto l_0x1012_842e; /* jmp 0x1012842e */
        l_0x1012_8383:
            ii(0x1012_8383, 5); mov(eax, 0x1c);                         /* mov eax, 0x1c */
            ii(0x1012_8388, 5); call(Definitions.sys_new, 0x3_da73);    /* call 0x10165e00 */
            ii(0x1012_838d, 6); mov(memd[ss, ebp - 0x98], eax);         /* mov [ebp-0x98], eax */
            ii(0x1012_8393, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x1012_8399, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
            ii(0x1012_839f, 7); cmp(memd[ss, ebp - 0x9c], 0);           /* cmp dword [ebp-0x9c], 0x0 */
            ii(0x1012_83a6, 2); if(jz(0x1012_83d9, 0x31)) goto l_0x1012_83d9; /* jz 0x101283d9 */
            ii(0x1012_83a8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_83ab, 3); mov(ebx, memd[ds, eax + 0x41]);         /* mov ebx, [eax+0x41] */
            ii(0x1012_83ae, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_83b1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_83b4, 3); mov(edx, memd[ds, eax + 0x3f]);         /* mov edx, [eax+0x3f] */
            ii(0x1012_83b7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_83ba, 6); mov(eax, memd[ss, ebp - 0x98]);         /* mov eax, [ebp-0x98] */
            ii(0x1012_83c0, 5); call(Definitions.my_ctor_c20, -0xe46f); /* call 0x10119f56 */
            ii(0x1012_83c5, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
            ii(0x1012_83cb, 6); mov(eax, memd[ss, ebp - 0xa0]);         /* mov eax, [ebp-0xa0] */
            ii(0x1012_83d1, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
            ii(0x1012_83d7, 2); jmp(0x1012_83e5, 0xc); goto l_0x1012_83e5; /* jmp 0x101283e5 */
        l_0x1012_83d9:
            ii(0x1012_83d9, 6); mov(eax, memd[ss, ebp - 0x9c]);         /* mov eax, [ebp-0x9c] */
            ii(0x1012_83df, 6); mov(memd[ss, ebp - 0xa4], eax);         /* mov [ebp-0xa4], eax */
        l_0x1012_83e5:
            ii(0x1012_83e5, 6); mov(edx, memd[ss, ebp - 0xa4]);         /* mov edx, [ebp-0xa4] */
            ii(0x1012_83eb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_83ee, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_83f1, 5); call(0x1007_6a34, -0xb_19c2);           /* call 0x10076a34 */
            ii(0x1012_83f6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_83f9, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1012_83fc, 5); call(0x1007_69d8, -0xb_1a29);           /* call 0x100769d8 */
            ii(0x1012_8401, 6); mov(memd[ss, ebp - 0xa8], eax);         /* mov [ebp-0xa8], eax */
            ii(0x1012_8407, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x1012_840d, 3); mov(ecx, memd[ds, eax + 0x2]);          /* mov ecx, [eax+0x2] */
            ii(0x1012_8410, 6); mov(ebx, memd[ss, ebp - 0x84]);         /* mov ebx, [ebp-0x84] */
            ii(0x1012_8416, 3); add(ebx, 0x1a);                         /* add ebx, 0x1a */
            ii(0x1012_8419, 6); mov(eax, memd[ss, ebp - 0x84]);         /* mov eax, [ebp-0x84] */
            ii(0x1012_841f, 3); mov(edx, memd[ds, eax + 0x16]);         /* mov edx, [eax+0x16] */
            ii(0x1012_8422, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_8425, 6); mov(eax, memd[ss, ebp - 0xa8]);         /* mov eax, [ebp-0xa8] */
            ii(0x1012_842b, 3); call_abs(memd[ds, ecx + 0x40]);         /* call dword [ecx+0x40] */
        l_0x1012_842e:
            ii(0x1012_842e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8431, 5); call(0x1015_48ba, 0x2_c484);            /* call 0x101548ba */
        l_0x1012_8436:
            ii(0x1012_8436, 5); jmp(0x1012_85f4, 0x1b9); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_843b:
            ii(0x1012_843b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_843d, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_8441, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_8446, 5); call(0x1010_3eba, -0x2_4591);           /* call 0x10103eba */
            ii(0x1012_844b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_844e, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_8452, 2); if(jnz(0x1012_845f, 0xb)) goto l_0x1012_845f; /* jnz 0x1012845f */
            ii(0x1012_8454, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_8458, 5); call(0x1012_6a47, -0x1a16);             /* call 0x10126a47 */
            ii(0x1012_845d, 2); jmp(0x1012_8469, 0xa); goto l_0x1012_8469; /* jmp 0x10128469 */
        l_0x1012_845f:
            ii(0x1012_845f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8461, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8464, 5); call(0x1014_f017, 0x2_6bae);            /* call 0x1014f017 */
        l_0x1012_8469:
            ii(0x1012_8469, 5); jmp(0x1012_85f4, 0x186); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_846e:
            ii(0x1012_846e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8470, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_8474, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_8479, 5); call(0x1010_3eba, -0x2_45c4);           /* call 0x10103eba */
            ii(0x1012_847e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_8481, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_8485, 2); if(jnz(0x1012_8492, 0xb)) goto l_0x1012_8492; /* jnz 0x10128492 */
            ii(0x1012_8487, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_848b, 5); call(0x1012_6a47, -0x1a49);             /* call 0x10126a47 */
            ii(0x1012_8490, 2); jmp(0x1012_849a, 0x8); goto l_0x1012_849a; /* jmp 0x1012849a */
        l_0x1012_8492:
            ii(0x1012_8492, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_8495, 5); call(0x1014_f5c1, 0x2_7127);            /* call 0x1014f5c1 */
        l_0x1012_849a:
            ii(0x1012_849a, 5); jmp(0x1012_85f4, 0x155); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_849f:
            ii(0x1012_849f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_84a1, 4); mov(dx, memw[ss, ebp - 0x14]);          /* mov dx, [ebp-0x14] */
            ii(0x1012_84a5, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_84aa, 5); call(0x1010_3eba, -0x2_45f5);           /* call 0x10103eba */
            ii(0x1012_84af, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_84b2, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_84b6, 2); if(jnz(0x1012_84c3, 0xb)) goto l_0x1012_84c3; /* jnz 0x101284c3 */
            ii(0x1012_84b8, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1012_84bc, 5); call(0x1012_6a47, -0x1a7a);             /* call 0x10126a47 */
            ii(0x1012_84c1, 2); jmp(0x1012_84d0, 0xd); goto l_0x1012_84d0; /* jmp 0x101284d0 */
        l_0x1012_84c3:
            ii(0x1012_84c3, 5); mov(edx, 0x101c_59f5);                  /* mov edx, 0x101c59f5 */
            ii(0x1012_84c8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_84cb, 5); call(0x1014_fabe, 0x2_75ee);            /* call 0x1014fabe */
        l_0x1012_84d0:
            ii(0x1012_84d0, 5); jmp(0x1012_85f4, 0x11f); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_84d5:
            ii(0x1012_84d5, 5); mov(eax, StringDefinitions.GamePausedClickOkToContinue2); /* mov eax, 0x101a82e8 */
            ii(0x1012_84da, 5); call(0x1011_6b06, -0x1_19d9);           /* call 0x10116b06 */
            ii(0x1012_84df, 5); jmp(0x1012_85f4, 0x110); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_84e4:
            ii(0x1012_84e4, 7); mov(memb[ds, 0x101c_5866], 0x1);        /* mov byte [0x101c5866], 0x1 */
            ii(0x1012_84eb, 5); jmp(0x1012_85f4, 0x104); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        l_0x1012_84f0:
            ii(0x1012_84f0, 5); jmp(0x1012_85f4, 0xff); goto l_0x1012_85f4; /* jmp 0x101285f4 */
        //  ii(0x1012_84f5, 3); lea(eax, eax + 0);                      /* lea eax, [eax] */
        //  ii(0x1012_84f8, 212); /* Служебная область с абсолютными адресами переходов. (0x1012_7638, 0x1012_7d4b, 0x1012_84f0, 0x1012_84f0, 0x1012_84f0, 0x1012_7cef, 0x1012_7d60, 0x1012_7e8b, 0x1012_7f34, 0x1012_7f84, 0x1012_7f92, 0x1012_7fe4, 0x1012_8003, 0x1012_802c, 0x1012_8044, 0x1012_84f0, 0x1012_8089, 0x1012_80cb, 0x1012_80d5, 0x1012_84f0, 0x1012_7fa0, 0x1012_813c, 0x1012_7fae, 0x1012_8184, 0x1012_81a5, 0x1012_84f0, 0x1012_81c6, 0x1012_84f0, 0x1012_77d5, 0x1012_77f3, 0x1012_7829, 0x1012_78e1, 0x1012_78e1, 0x1012_7cb3, 0x1012_7d23, 0x1012_7ad8, 0x1012_7bb6, 0x1012_7c72, 0x1012_81e9, 0x1012_84d5, 0x1012_84e4, 0x1012_843b, 0x1012_8003, 0x1012_849f, 0x1012_7691, 0x1012_7662, 0x1012_7ef7, 0x1012_84f0, 0x1012_7ed6, 0x1012_81ba, 0x1012_846e, 0x1012_7eeb, 0x1012_764d). */
        l_0x1012_85cc:
            ii(0x1012_85cc, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_85cf, 6); mov(memb[ss, ebp - 0xac], al);          /* mov [ebp-0xac], al */
            ii(0x1012_85d5, 7); cmp(memb[ss, ebp - 0xac], 0x34);        /* cmp byte [ebp-0xac], 0x34 */
            ii(0x1012_85dc, 6); if(ja(0x1012_84f0, -0xf2)) goto l_0x1012_84f0; /* ja 0x101284f0 */
            ii(0x1012_85e2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_85e4, 6); mov(al, memb[ss, ebp - 0xac]);          /* mov al, [ebp-0xac] */
            ii(0x1012_85ea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_85ed, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1012_84f8]))
            {
                case 0x1012_7638:
                    goto l_0x1012_7638;
                case 0x1012_764d:
                    goto l_0x1012_764d;
                case 0x1012_7662:
                    goto l_0x1012_7662;
                case 0x1012_7691:
                    goto l_0x1012_7691;
                case 0x1012_77d5:
                    goto l_0x1012_77d5;
                case 0x1012_77f3:
                    goto l_0x1012_77f3;
                case 0x1012_7829:
                    goto l_0x1012_7829;
                case 0x1012_78e1:
                    goto l_0x1012_78e1;
                case 0x1012_7ad8:
                    goto l_0x1012_7ad8;
                case 0x1012_7bb6:
                    goto l_0x1012_7bb6;
                case 0x1012_7c72:
                    goto l_0x1012_7c72;
                case 0x1012_7cb3:
                    goto l_0x1012_7cb3;
                case 0x1012_7cef:
                    goto l_0x1012_7cef;
                case 0x1012_7d23:
                    goto l_0x1012_7d23;
                case 0x1012_7d4b:
                    goto l_0x1012_7d4b;
                case 0x1012_7d60:
                    goto l_0x1012_7d60;
                case 0x1012_7e8b:
                    goto l_0x1012_7e8b;
                case 0x1012_7ed6:
                    goto l_0x1012_7ed6;
                case 0x1012_7eeb:
                    goto l_0x1012_7eeb;
                case 0x1012_7ef7:
                    goto l_0x1012_7ef7;
                case 0x1012_7f34:
                    goto l_0x1012_7f34;
                case 0x1012_7f84:
                    goto l_0x1012_7f84;
                case 0x1012_7f92:
                    goto l_0x1012_7f92;
                case 0x1012_7fa0:
                    goto l_0x1012_7fa0;
                case 0x1012_7fae:
                    goto l_0x1012_7fae;
                case 0x1012_7fe4:
                    goto l_0x1012_7fe4;
                case 0x1012_8003:
                    goto l_0x1012_8003;
                case 0x1012_802c:
                    goto l_0x1012_802c;
                case 0x1012_8044:
                    goto l_0x1012_8044;
                case 0x1012_8089:
                    goto l_0x1012_8089;
                case 0x1012_80cb:
                    goto l_0x1012_80cb;
                case 0x1012_80d5:
                    goto l_0x1012_80d5;
                case 0x1012_813c:
                    goto l_0x1012_813c;
                case 0x1012_8184:
                    goto l_0x1012_8184;
                case 0x1012_81a5:
                    goto l_0x1012_81a5;
                case 0x1012_81ba:
                    goto l_0x1012_81ba;
                case 0x1012_81c6:
                    goto l_0x1012_81c6;
                case 0x1012_81e9:
                    goto l_0x1012_81e9;
                case 0x1012_843b:
                    goto l_0x1012_843b;
                case 0x1012_846e:
                    goto l_0x1012_846e;
                case 0x1012_849f:
                    goto l_0x1012_849f;
                case 0x1012_84d5:
                    goto l_0x1012_84d5;
                case 0x1012_84e4:
                    goto l_0x1012_84e4;
                case 0x1012_84f0:
                    goto l_0x1012_84f0;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x101284f8] */
        l_0x1012_85f4:
            ii(0x1012_85f4, 5); jmp(0x1012_760c, -0xfed); goto l_0x1012_760c; /* jmp 0x1012760c */
        l_0x1012_85f9:
            ii(0x1012_85f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_85fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_85fc, 1); pop(edi);                               /* pop edi */
            ii(0x1012_85fd, 1); pop(esi);                               /* pop esi */
            ii(0x1012_85fe, 1); pop(edx);                               /* pop edx */
            ii(0x1012_85ff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_8600, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_8601, 1); ret();                                  /* ret */
        }
    }
}
