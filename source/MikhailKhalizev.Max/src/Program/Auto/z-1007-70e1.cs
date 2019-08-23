using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_70e1-56b718b3")]
        public void Method_1007_70e1()
        {
            ii(0x1007_70e1, 5); push(0x50);                             /* push 0x50 */
            ii(0x1007_70e6, 5); call(Definitions.sys_check_available_stack_size, 0xe_ec67); /* call 0x10165d52 */
            ii(0x1007_70eb, 1); push(esi);                              /* push esi */
            ii(0x1007_70ec, 1); push(edi);                              /* push edi */
            ii(0x1007_70ed, 1); push(ebp);                              /* push ebp */
            ii(0x1007_70ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_70f0, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1007_70f6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_70f9, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_70fc, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1007_70ff, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1007_7102, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7105, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_7108, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_710d, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_7113, 5); mov(edx, 0x101c_31c4);                  /* mov edx, 0x101c31c4 */
            ii(0x1007_7118, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_711a, 5); call(0x1008_a0c8, 0x1_2fa9);            /* call 0x1008a0c8 */
            ii(0x1007_711f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_7122, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_7125, 5); call(Definitions.my_ctor_0x101b_4184, -0x63a); /* call 0x10076af0 */
            ii(0x1007_712a, 4); mov(memb[ss, ebp - 0x1c], 0);           /* mov byte [ebp-0x1c], 0x0 */
            ii(0x1007_712e, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1007_7133, 4); movsx(ebx, memb[ss, ebp + 0x10]);       /* movsx ebx, byte [ebp+0x10] */
            ii(0x1007_7137, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_713a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_713d, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_7140, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_7145, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_714b, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_7150, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_7152, 5); call(0x100c_1fd4, 0x4_ae7d);            /* call 0x100c1fd4 */
            ii(0x1007_7157, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1007_715a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_715d, 5); mov(memw[ds, eax], 0x7fff);             /* mov word [eax], 0x7fff */
            ii(0x1007_7162, 7); mov(memd[ss, ebp - 0x24], 0x7fff);      /* mov dword [ebp-0x24], 0x7fff */
            ii(0x1007_7169, 7); mov(memd[ss, ebp - 0x28], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1007_7170, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7173, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_7176, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_7179, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_717c, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_717f, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_7182, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_7185, 5); call(0x100a_30a2, 0x2_bf18);            /* call 0x100a30a2 */
            ii(0x1007_718a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_718c, 2); if(jz(0x1007_71e3, 0x55)) goto l_0x1007_71e3; /* jz 0x100771e3 */
            ii(0x1007_718e, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7191, 4); mov(dx, memw[ds, eax + 0x1a]);          /* mov dx, [eax+0x1a] */
            ii(0x1007_7195, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7198, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1007_719b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_719e, 4); mov(dx, memw[ds, eax + 0x1c]);          /* mov dx, [eax+0x1c] */
            ii(0x1007_71a2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_71a5, 4); mov(memw[ds, eax + 0x2], dx);           /* mov [eax+0x2], dx */
            ii(0x1007_71a9, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1007_71b0, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_71b4, 2); if(jz(0x1007_71d6, 0x20)) goto l_0x1007_71d6; /* jz 0x100771d6 */
            ii(0x1007_71b6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_71b9, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1007_71bc, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1007_71bf, 3); add(edx, memd[ss, ebp - 0x20]);         /* add edx, [ebp-0x20] */
            ii(0x1007_71c2, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_71c5, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_71c7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_71ca, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_71cc, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1007_71ce, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_71d0, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_71d3, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1007_71d6:
            ii(0x1007_71d6, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_71d9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_71dc, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1007_71df, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
        l_0x1007_71e3:
            ii(0x1007_71e3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_71e6, 4); test(memb[ds, eax + 0x12], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1007_71ea, 2); if(jz(0x1007_71f5, 0x9)) goto l_0x1007_71f5; /* jz 0x100771f5 */
            ii(0x1007_71ec, 7); mov(memd[ss, ebp - 0x2c], 0x3);         /* mov dword [ebp-0x2c], 0x3 */
            ii(0x1007_71f3, 2); jmp(0x1007_71fc, 0x7); goto l_0x1007_71fc; /* jmp 0x100771fc */
        l_0x1007_71f5:
            ii(0x1007_71f5, 7); mov(memd[ss, ebp - 0x2c], 0x2);         /* mov dword [ebp-0x2c], 0x2 */
        l_0x1007_71fc:
            ii(0x1007_71fc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_71ff, 4); mov(ax, memw[ds, eax + 0x1a]);          /* mov ax, [eax+0x1a] */
            ii(0x1007_7203, 1); dec(eax);                               /* dec eax */
            ii(0x1007_7204, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1007_7208, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_720b, 4); mov(ax, memw[ds, eax + 0x1c]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_720f, 3); add(eax, memd[ss, ebp - 0x2c]);         /* add eax, [ebp-0x2c] */
            ii(0x1007_7212, 1); dec(eax);                               /* dec eax */
            ii(0x1007_7213, 4); mov(memw[ss, ebp - 0x16], ax);          /* mov [ebp-0x16], ax */
            ii(0x1007_7217, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
            ii(0x1007_721e, 2); jmp(0x1007_7224, 0x4); goto l_0x1007_7224; /* jmp 0x10077224 */
        l_0x1007_7220:
            ii(0x1007_7220, 4); add(memd[ss, ebp - 0x30], 0x2);         /* add dword [ebp-0x30], 0x2 */
        l_0x1007_7224:
            ii(0x1007_7224, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1007_7228, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1007_722b, 6); if(jge(0x1007_7370, 0x13f)) goto l_0x1007_7370; /* jge 0x10077370 */
            ii(0x1007_7231, 7); mov(memd[ss, ebp - 0x34], 0);           /* mov dword [ebp-0x34], 0x0 */
            ii(0x1007_7238, 2); jmp(0x1007_7240, 0x6); goto l_0x1007_7240; /* jmp 0x10077240 */
        l_0x1007_723a:
            ii(0x1007_723a, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1007_723d, 3); inc(memd[ss, ebp - 0x34]);              /* inc dword [ebp-0x34] */
        l_0x1007_7240:
            ii(0x1007_7240, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x1007_7243, 4); cmp(ax, memw[ss, ebp - 0x2c]);          /* cmp ax, [ebp-0x2c] */
            ii(0x1007_7247, 6); if(jge(0x1007_736b, 0x11e)) goto l_0x1007_736b; /* jge 0x1007736b */
            ii(0x1007_724d, 4); movsx(eax, memw[ss, ebp - 0x30]);       /* movsx eax, word [ebp-0x30] */
            ii(0x1007_7251, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_7254, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1007_7259, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_725b, 3); lea(eax, memd[ss, ebp - 0x18]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_725e, 5); call(0x1008_b1a4, 0x1_3f41);            /* call 0x1008b1a4 */
            ii(0x1007_7263, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_7267, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_7269, 2); if(jl(0x1007_7277, 0xc)) goto l_0x1007_7277; /* jl 0x10077277 */
            ii(0x1007_726b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_726e, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1007_7275, 2); if(jl(0x1007_7279, 0x2)) goto l_0x1007_7279; /* jl 0x10077279 */
        l_0x1007_7277:
            ii(0x1007_7277, 2); jmp(0x1007_7281, 0x8); goto l_0x1007_7281; /* jmp 0x10077281 */
        l_0x1007_7279:
            ii(0x1007_7279, 4); movsx(eax, memw[ss, ebp - 0x16]);       /* movsx eax, word [ebp-0x16] */
            ii(0x1007_727d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_727f, 2); if(jge(0x1007_7283, 0x2)) goto l_0x1007_7283; /* jge 0x10077283 */
        l_0x1007_7281:
            ii(0x1007_7281, 2); jmp(0x1007_728f, 0xc); goto l_0x1007_728f; /* jmp 0x1007728f */
        l_0x1007_7283:
            ii(0x1007_7283, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1007_7286, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1007_728d, 2); if(jl(0x1007_7294, 0x5)) goto l_0x1007_7294; /* jl 0x10077294 */
        l_0x1007_728f:
            ii(0x1007_728f, 5); jmp(0x1007_7366, 0xd2); goto l_0x1007_7366; /* jmp 0x10077366 */
        l_0x1007_7294:
            ii(0x1007_7294, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_7298, 2); if(jz(0x1007_72b4, 0x1a)) goto l_0x1007_72b4; /* jz 0x100772b4 */
            ii(0x1007_729a, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_729e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_72a1, 3); add(eax, memd[ss, ebp - 0x20]);         /* add eax, [ebp-0x20] */
            ii(0x1007_72a4, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1007_72a8, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1007_72aa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_72ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_72ae, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x1007_72b1, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
        l_0x1007_72b4:
            ii(0x1007_72b4, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_72b7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_72ba, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1007_72bd, 6); if(jg(0x1007_7366, 0xa3)) goto l_0x1007_7366; /* jg 0x10077366 */
            ii(0x1007_72c3, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_72c6, 3); mov(eax, memd[ss, ebp - 0x16]);         /* mov eax, [ebp-0x16] */
            ii(0x1007_72c9, 4); sub(ax, memw[ds, edx + 0x1c]);          /* sub ax, [edx+0x1c] */
            ii(0x1007_72cd, 1); cwde();                                 /* cwde */
            ii(0x1007_72ce, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1007_72d1, 3); mov(ebx, memd[ss, ebp - 0x18]);         /* mov ebx, [ebp-0x18] */
            ii(0x1007_72d4, 4); sub(bx, memw[ds, edx + 0x1a]);          /* sub bx, [edx+0x1a] */
            ii(0x1007_72d8, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1007_72da, 3); movsx(ebx, dx);                         /* movsx ebx, dx */
            ii(0x1007_72dd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_72df, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_72e1, 5); call(0x100a_5f65, 0x2_ec7f);            /* call 0x100a5f65 */
            ii(0x1007_72e6, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x1007_72e9, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_72ec, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_72ef, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1007_72f2, 2); if(jl(0x1007_72fd, 0x9)) goto l_0x1007_72fd; /* jl 0x100772fd */
            ii(0x1007_72f4, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1007_72f7, 4); cmp(ax, memw[ss, ebp - 0x24]);          /* cmp ax, [ebp-0x24] */
            ii(0x1007_72fb, 2); if(jge(0x1007_7366, 0x69)) goto l_0x1007_7366; /* jge 0x10077366 */
        l_0x1007_72fd:
            ii(0x1007_72fd, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1007_7301, 2); if(jz(0x1007_731a, 0x17)) goto l_0x1007_731a; /* jz 0x1007731a */
            ii(0x1007_7303, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_7307, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_730a, 3); add(eax, memd[ss, ebp - 0x14]);         /* add eax, [ebp-0x14] */
            ii(0x1007_730d, 4); movsx(edx, memw[ss, ebp - 0x16]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1007_7311, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_7313, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_7315, 3); test(memb[ds, eax], 0x8);               /* test byte [eax], 0x8 */
            ii(0x1007_7318, 2); if(jnz(0x1007_7346, 0x2c)) goto l_0x1007_7346; /* jnz 0x10077346 */
        l_0x1007_731a:
            ii(0x1007_731a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1007_731f, 1); push(eax);                              /* push eax */
            ii(0x1007_7320, 4); movsx(ecx, memw[ss, ebp - 0x16]);       /* movsx ecx, word [ebp-0x16] */
            ii(0x1007_7324, 4); movsx(ebx, memw[ss, ebp - 0x18]);       /* movsx ebx, word [ebp-0x18] */
            ii(0x1007_7328, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_732b, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_732e, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_7330, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_7333, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_7336, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_7339, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_733c, 5); call(0x1007_02b9, -0x7088);             /* call 0x100702b9 */
            ii(0x1007_7341, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1007_7344, 2); if(jnz(0x1007_7348, 0x2)) goto l_0x1007_7348; /* jnz 0x10077348 */
        l_0x1007_7346:
            ii(0x1007_7346, 2); jmp(0x1007_7366, 0x1e); goto l_0x1007_7366; /* jmp 0x10077366 */
        l_0x1007_7348:
            ii(0x1007_7348, 4); mov(memb[ss, ebp - 0x1c], 0x1);         /* mov byte [ebp-0x1c], 0x1 */
            ii(0x1007_734c, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1007_734f, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_7352, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1007_7355, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x1007_7358, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1007_735b, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x1007_735e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_7361, 5); call(0x1008_8b44, 0x1_17de);            /* call 0x10088b44 */
        l_0x1007_7366:
            ii(0x1007_7366, 5); jmp(0x1007_723a, -0x131); goto l_0x1007_723a; /* jmp 0x1007723a */
        l_0x1007_736b:
            ii(0x1007_736b, 5); jmp(0x1007_7220, -0x150); goto l_0x1007_7220; /* jmp 0x10077220 */
        l_0x1007_7370:
            ii(0x1007_7370, 3); mov(al, memb[ss, ebp - 0x1c]);          /* mov al, [ebp-0x1c] */
            ii(0x1007_7373, 3); mov(memb[ss, ebp - 0x3c], al);          /* mov [ebp-0x3c], al */
            ii(0x1007_7376, 3); mov(al, memb[ss, ebp - 0x3c]);          /* mov al, [ebp-0x3c] */
            ii(0x1007_7379, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_737b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_737c, 1); pop(edi);                               /* pop edi */
            ii(0x1007_737d, 1); pop(esi);                               /* pop esi */
            ii(0x1007_737e, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
