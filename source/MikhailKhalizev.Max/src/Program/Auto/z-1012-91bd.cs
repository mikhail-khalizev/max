using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_91bd-276986ab")]
        public void Method_1012_91bd()
        {
            ii(0x1012_91bd, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1012_91c2, 5); call(Definitions.sys_check_available_stack_size, 0x3_cb8b); /* call 0x10165d52 */
            ii(0x1012_91c7, 1); push(ecx);                              /* push ecx */
            ii(0x1012_91c8, 1); push(esi);                              /* push esi */
            ii(0x1012_91c9, 1); push(edi);                              /* push edi */
            ii(0x1012_91ca, 1); push(ebp);                              /* push ebp */
            ii(0x1012_91cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_91cd, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_91d3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_91d6, 3); mov(memb[ss, ebp - 0x8], dl);           /* mov [ebp-0x8], dl */
            ii(0x1012_91d9, 3); mov(memb[ss, ebp - 0x4], bl);           /* mov [ebp-0x4], bl */
            ii(0x1012_91dc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_91de, 5); call(0x100e_883d, -0x4_09a6);           /* call 0x100e883d */
            ii(0x1012_91e3, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_91e6, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1012_91e9, 5); mov(memb[ds, 0x101c_59c8], al);         /* mov [0x101c59c8], al */
            ii(0x1012_91ee, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_91f0, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1012_91f3, 5); mov(memd[ds, 0x101c_562c], eax);        /* mov [0x101c562c], eax */
            ii(0x1012_91f8, 5); call(0x1013_6316, 0xd119);              /* call 0x10136316 */
            ii(0x1012_91fd, 5); call(0x1012_63d4, -0x2e2e);             /* call 0x101263d4 */
            ii(0x1012_9202, 4); cmp(memb[ss, ebp - 0x4], 0);            /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1012_9206, 6); if(jz(0x1012_9393, 0x187)) goto l_0x1012_9393; /* jz 0x10129393 */
            ii(0x1012_920c, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_9211, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x1012_9214, 5); jmp(0x1012_9325, 0x10c); goto l_0x1012_9325; /* jmp 0x10129325 */
        l_0x1012_9219:
            ii(0x1012_9219, 9); mov(memw[ds, 0x101c_59c6], 0xd7);       /* mov word [0x101c59c6], 0xd7 */
        l_0x1012_9222:
            ii(0x1012_9222, 5); call(0x1012_5128, -0x40ff);             /* call 0x10125128 */
            ii(0x1012_9227, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_922c, 5); mov(ebx, 0x101c_5e74);                  /* mov ebx, 0x101c5e74 */
            ii(0x1012_9231, 5); mov(edx, 0x5a);                         /* mov edx, 0x5a */
            ii(0x1012_9236, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_923b, 5); call(0x1010_6281, -0x2_2fbf);           /* call 0x10106281 */
            ii(0x1012_9240, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1012_9245, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_9247, 5); mov(eax, 0x101c_5e74);                  /* mov eax, 0x101c5e74 */
            ii(0x1012_924c, 5); call(/* sys */ 0x1017_d710, 0x5_44bf);  /* call 0x1017d710 */
            ii(0x1012_9251, 6); mov(memw[ds, 0x101b_b458], ax);         /* mov [0x101bb458], ax */
            ii(0x1012_9257, 5); mov(eax, 0x5b);                         /* mov eax, 0x5b */
            ii(0x1012_925c, 5); call(0x1007_5fdc, -0xb_3285);           /* call 0x10075fdc */
            ii(0x1012_9261, 5); mov(memd[ds, 0x101b_b460], eax);        /* mov [0x101bb460], eax */
            ii(0x1012_9266, 6); mov(edx, memd[ds, 0x101b_b460]);        /* mov edx, [0x101bb460] */
            ii(0x1012_926c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_926e, 6); mov(ax, memw[ds, 0x101b_b458]);         /* mov ax, [0x101bb458] */
            ii(0x1012_9274, 5); call(0x1012_51b4, -0x40c5);             /* call 0x101251b4 */
            ii(0x1012_9279, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_927b, 2); if(jnz(0x1012_9292, 0x15)) goto l_0x1012_9292; /* jnz 0x10129292 */
            ii(0x1012_927d, 9); mov(memw[ds, 0x101b_b458], 0);          /* mov word [0x101bb458], 0x0 */
            ii(0x1012_9286, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_928d, 5); jmp(0x1012_93b9, 0x127); goto l_0x1012_93b9; /* jmp 0x101293b9 */
        l_0x1012_9292:
            ii(0x1012_9292, 5); jmp(0x1012_9353, 0xbc); goto l_0x1012_9353; /* jmp 0x10129353 */
        l_0x1012_9297:
            ii(0x1012_9297, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9299, 5); call(0x100e_4971, -0x4_492d);           /* call 0x100e4971 */
            ii(0x1012_929e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_92a0, 2); if(jz(0x1012_92b9, 0x17)) goto l_0x1012_92b9; /* jz 0x101292b9 */
            ii(0x1012_92a2, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1012_92a7, 5); call(0x1007_5fdc, -0xb_32d0);           /* call 0x10075fdc */
            ii(0x1012_92ac, 5); call(0x1010_79cc, -0x2_18e5);           /* call 0x101079cc */
            ii(0x1012_92b1, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_92b3, 6); if(jz(0x1012_9353, 0x9a)) goto l_0x1012_9353; /* jz 0x10129353 */
        l_0x1012_92b9:
            ii(0x1012_92b9, 5); call(0x100d_533c, -0x5_3f82);           /* call 0x100d533c */
            ii(0x1012_92be, 1); cwde();                                 /* cwde */
            ii(0x1012_92bf, 1); push(eax);                              /* push eax */
            ii(0x1012_92c0, 5); call(0x100d_5360, -0x5_3f65);           /* call 0x100d5360 */
            ii(0x1012_92c5, 1); cwde();                                 /* cwde */
            ii(0x1012_92c6, 1); push(eax);                              /* push eax */
            ii(0x1012_92c7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_92cc, 1); push(eax);                              /* push eax */
            ii(0x1012_92cd, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_92cf, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1012_92d4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_92d6, 5); call(0x100e_883d, -0x4_0a9e);           /* call 0x100e883d */
            ii(0x1012_92db, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_92dd, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1012_92e2, 5); call(0x100e_8c51, -0x4_0696);           /* call 0x100e8c51 */
            ii(0x1012_92e7, 5); call(0x100c_aa00, -0x5_e8ec);           /* call 0x100caa00 */
            ii(0x1012_92ec, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_92f1, 1); push(eax);                              /* push eax */
            ii(0x1012_92f2, 5); call(0x100c_aa20, -0x5_e8d7);           /* call 0x100caa20 */
            ii(0x1012_92f7, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_92f9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_92fe, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_9303, 5); mov(eax, StringDefinitions.NetworkNotAvailableOrIpxSocketNotFoundUnableToContinueWithConnection); /* mov eax, 0x101a833f */
            ii(0x1012_9308, 5); call(0x1011_5d23, -0x1_35ea);           /* call 0x10115d23 */
            ii(0x1012_930d, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_9314, 5); jmp(0x1012_93b9, 0xa0); goto l_0x1012_93b9; /* jmp 0x101293b9 */
        l_0x1012_9319:
            ii(0x1012_9319, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_9320, 5); jmp(0x1012_93b9, 0x94); goto l_0x1012_93b9; /* jmp 0x101293b9 */
        l_0x1012_9325:
            ii(0x1012_9325, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x1012_9328, 3); mov(memb[ss, ebp - 0x1c], al);          /* mov [ebp-0x1c], al */
            ii(0x1012_932b, 4); cmp(memb[ss, ebp - 0x1c], 0x2);         /* cmp byte [ebp-0x1c], 0x2 */
            ii(0x1012_932f, 2); if(jb(0x1012_9347, 0x16)) goto l_0x1012_9347; /* jb 0x10129347 */
            ii(0x1012_9331, 4); cmp(memb[ss, ebp - 0x1c], 0x2);         /* cmp byte [ebp-0x1c], 0x2 */
            ii(0x1012_9335, 6); if(jbe(0x1012_9219, -0x122)) goto l_0x1012_9219; /* jbe 0x10129219 */
            ii(0x1012_933b, 4); cmp(memb[ss, ebp - 0x1c], 0x3);         /* cmp byte [ebp-0x1c], 0x3 */
            ii(0x1012_933f, 6); if(jz(0x1012_9297, -0xae)) goto l_0x1012_9297; /* jz 0x10129297 */
            ii(0x1012_9345, 2); jmp(0x1012_9319, -0x2e); goto l_0x1012_9319; /* jmp 0x10129319 */
        l_0x1012_9347:
            ii(0x1012_9347, 4); cmp(memb[ss, ebp - 0x1c], 0x1);         /* cmp byte [ebp-0x1c], 0x1 */
            ii(0x1012_934b, 6); if(jz(0x1012_9222, -0x12f)) goto l_0x1012_9222; /* jz 0x10129222 */
            ii(0x1012_9351, 2); jmp(0x1012_9319, -0x3a); goto l_0x1012_9319; /* jmp 0x10129319 */
        l_0x1012_9353:
            ii(0x1012_9353, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_9355, 5); mov(al, memb[ds, 0x101c_59c8]);         /* mov al, [0x101c59c8] */
            ii(0x1012_935a, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1012_935d, 2); if(jnz(0x1012_9393, 0x34)) goto l_0x1012_9393; /* jnz 0x10129393 */
            ii(0x1012_935f, 7); cmp(memd[ds, 0x101c_562c], 0);          /* cmp dword [0x101c562c], 0x0 */
            ii(0x1012_9366, 2); if(jz(0x1012_937c, 0x14)) goto l_0x1012_937c; /* jz 0x1012937c */
            ii(0x1012_9368, 5); call(0x1012_4e4f, -0x451e);             /* call 0x10124e4f */
            ii(0x1012_936d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_936f, 2); if(jnz(0x1012_937a, 0x9)) goto l_0x1012_937a; /* jnz 0x1012937a */
            ii(0x1012_9371, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_9378, 2); jmp(0x1012_93b9, 0x3f); goto l_0x1012_93b9; /* jmp 0x101293b9 */
        l_0x1012_937a:
            ii(0x1012_937a, 2); jmp(0x1012_938e, 0x12); goto l_0x1012_938e; /* jmp 0x1012938e */
        l_0x1012_937c:
            ii(0x1012_937c, 5); call(0x1012_4e9c, -0x44e5);             /* call 0x10124e9c */
            ii(0x1012_9381, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_9383, 2); if(jnz(0x1012_938e, 0x9)) goto l_0x1012_938e; /* jnz 0x1012938e */
            ii(0x1012_9385, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x1012_938c, 2); jmp(0x1012_93b9, 0x2b); goto l_0x1012_93b9; /* jmp 0x101293b9 */
        l_0x1012_938e:
            ii(0x1012_938e, 5); call(0x1010_e943, -0x1_aa50);           /* call 0x1010e943 */
        l_0x1012_9393:
            ii(0x1012_9393, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_9395, 3); mov(bl, memb[ss, ebp - 0x4]);           /* mov bl, [ebp-0x4] */
            ii(0x1012_9398, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_939a, 6); mov(dl, memb[ds, 0x101c_59c8]);         /* mov dl, [0x101c59c8] */
            ii(0x1012_93a0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_93a2, 5); mov(al, memb[ds, 0x101c_562c]);         /* mov al, [0x101c562c] */
            ii(0x1012_93a7, 5); call(0x1011_4f29, -0x1_4483);           /* call 0x10114f29 */
            ii(0x1012_93ac, 5); mov(memd[ds, 0x101c_5624], eax);        /* mov [0x101c5624], eax */
            ii(0x1012_93b1, 5); mov(eax, memd[ds, 0x101c_5624]);        /* mov eax, [0x101c5624] */
            ii(0x1012_93b6, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1012_93b9:
            ii(0x1012_93b9, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1012_93bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_93be, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_93bf, 1); pop(edi);                               /* pop edi */
            ii(0x1012_93c0, 1); pop(esi);                               /* pop esi */
            ii(0x1012_93c1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_93c2, 1); ret();                                  /* ret */
        }
    }
}
